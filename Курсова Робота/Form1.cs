using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Курсова_Робота
{
    public partial class Form1 : Form
    {
        private readonly SoundManager _soundManager;
        private readonly Random _random = new Random();
        private List<Record> _records;
        
        private bool _isGameOver = false;
        private int _score = 0;
        private int _level = 1;
        
        private const int RoadSpeed = 10;
        private const int OpponentSpeed = 7;
        private const int CoinSpeed = 7;
        private const int PlayerSpeed = 13;
        
        private enum GameState { Running, Paused, Lost }
        private GameState _currentState;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            _records = RecordsManager.LoadRecords();
            _soundManager = new SoundManager("sound.wav");
            _soundManager.PlayLooping();
            
            _currentState = GameState.Paused;
            UpdateUI();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_currentState != GameState.Running) return;

            MoveRoad();
            MoveOpponents();
            MoveCoin();
            CheckCollisions();
        }

        private void MoveRoad()
        {
            Road.Top += RoadSpeed;
            Road2.Top += RoadSpeed;
            if (Road.Top >= 650)
            {
                Road.Top = 0;
                Road2.Top = -650;
            }
        }

        private void MoveOpponents()
        {
            Opponent1.Top += OpponentSpeed;
            Opponent2.Top += OpponentSpeed;

            if (Opponent1.Top >= 650) ResetOpponent(Opponent1, 150, 299);
            if (Opponent2.Top >= 650) ResetOpponent(Opponent2, 301, 560);
        }

        private void ResetOpponent(PictureBox opponent, int minX, int maxX)
        {
            opponent.Top = -130;
            opponent.Left = _random.Next(minX, maxX);
        }

        private void MoveCoin()
        {
            Coin.Top += CoinSpeed;
            if (Coin.Top >= 650) ResetCoin();
        }

        private void ResetCoin()
        {
            Coin.Top = -50;
            Coin.Left = _random.Next(150, 560);
        }

        private void CheckCollisions()
        {
            if (Player.Bounds.IntersectsWith(Opponent1.Bounds) || Player.Bounds.IntersectsWith(Opponent2.Bounds))
            {
                HandleGameOver();
            }
            else if (Player.Bounds.IntersectsWith(Coin.Bounds))
            {
                HandleCoinPickup();
            }
        }

        private void HandleGameOver()
        {
            _currentState = GameState.Lost;
            Timer.Enabled = false;
            _soundManager.Stop();
            SaveRecord();
            UpdateUI();
        }

        private void HandleCoinPickup()
        {
            _score++;
            if (_score % 10 == 0)
            {
                _level++;
            }
            ResetCoin();
            UpdateUI();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_currentState == GameState.Lost) return;

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Player.Left > 150)
                Player.Left -= PlayerSpeed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Player.Right < 700)
                Player.Left += PlayerSpeed;
        }

        private void Start_Click(object sender, EventArgs e) => SetGameState(GameState.Running);
        private void Pause_Click(object sender, EventArgs e) => SetGameState(GameState.Paused);
        private void Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void SetGameState(GameState newState)
        {
            _currentState = newState;
            Timer.Enabled = newState == GameState.Running;

            if (newState == GameState.Running) _soundManager.PlayLooping();
            else _soundManager.Stop();

            UpdateUI();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            _score = 0;
            _level = 1;

            ResetOpponent(Opponent1, 150, 299);
            ResetOpponent(Opponent2, 301, 560);
            ResetCoin();

            SetGameState(GameState.Running);
        }

        private void SaveRecord()
        {
            if (_currentState != GameState.Lost) return;

            string playerName = "";
            while (string.IsNullOrWhiteSpace(playerName))
            {
                playerName = Prompt.ShowDialog("Введіть ім'я", "New Record!");
                if (string.IsNullOrWhiteSpace(playerName))
                {
                    MessageBox.Show("Рекорд не збережено! Будь ласка, введіть ваше ім'я!", "Error");
                }
            }

            var existingRecord = _records.FirstOrDefault(r => r.PlayerName == playerName);
            if (existingRecord != null)
            {
                if (_score > existingRecord.Score) existingRecord.Score = _score;
            }
            else
            {
                _records.Add(new Record(playerName, _score));
            }

            _records = _records.OrderByDescending(r => r.Score).Take(10).ToList();
            RecordsManager.SaveRecords(_records);
        }

        private void ShowRecordsButton_Click(object sender, EventArgs e) => ShowRecords();

        private void ShowRecords()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Name       Score");
            foreach (var record in _records)
            {
                sb.AppendLine($"{record.PlayerName,-10} {record.Score}");
            }
            MessageBox.Show(sb.ToString(), "Records");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => _soundManager.Stop();

        private void UpdateUI()
        {
            Score.Text = $"Score: {_score}";
            Level.Text = $"Рівень: {_level}";

            Start.Visible = _currentState != GameState.Running;
            Pause.Visible = _currentState == GameState.Running;
            Timer.Enabled = _currentState == GameState.Running;
            Lose.Visible = _currentState == GameState.Lost;
            Restart.Visible = _currentState == GameState.Lost;
            LogMenuButton.Visible = _currentState != GameState.Running;
            ShowRecordsButton.Visible = _currentState != GameState.Running;
        }
    }

    public class SoundManager
    {
        private readonly SoundPlayer _player;

        public SoundManager(string soundFile)
        {
            _player = new SoundPlayer(soundFile);
        }

        public void PlayLooping() => _player.PlayLooping();
        public void Stop() => _player.Stop();
    }
}
