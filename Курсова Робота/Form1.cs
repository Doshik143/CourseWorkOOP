using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Курсова_Робота
{
    public partial class Form1 : Form
    {
        private SoundPlayer _player;
        private List<Record> records;
        private Point pos;
        private bool traffic, lose = false;
        private int coins = 0;
        private int level = 1;
        public Form1()
        {
            InitializeComponent();
            
            Lose.Visible = false;
            Restart.Visible = false;

            KeyPreview = true;

            Pause.Visible = true;
            Start.Visible = false;

            LogMenuButton.Visible = false;

            Level.Text = "Рівень: 1";

            records = RecordsManager.LoadRecords();

            ShowRecordsButton.Visible = false;

            _player = new SoundPlayer("sound.wav");
            _player.PlayLooping();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Escape)
                Application.Exit();
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateRoadPosition();    
            MoveGameObjects();       
            CheckCollisions();         
            HandleCoinCollection(); 
        }
        private void UpdateRoadPosition()
        {
            const int roadSpeed = 10;
            Road.Top += roadSpeed;
            Road2.Top += roadSpeed;

            if (Road.Top >= GameConstants.RoadResetPosition)
            {
                Road.Top = 0;
                Road2.Top = -GameConstants.RoadResetPosition;
            }
        }
        
        private void MoveGameObjects()
        {
            MoveOpponent(Opponent1, speed: 7, resetTop: -130, minSpawnX: 150, maxSpawnX: 299);
            MoveOpponent(Opponent2, speed: 7, resetTop: -400, minSpawnX: 301, maxSpawnX: 560);
            MoveCoin(speed: 7);
        }
        
        private void MoveOpponent(PictureBox opponent, int speed, int resetTop, int minSpawnX, int maxSpawnX)
        {
            opponent.Top += speed;
            if (opponent.Top >= GameConstants.RoadResetPosition)
            {
                opponent.Top = resetTop;
                opponent.Left = new Random().Next(minSpawnX, maxSpawnX);
            }
        }
        
        private void MoveCoin(int speed)
        {
            Coin.Top += speed;
            if (Coin.Top >= GameConstants.RoadResetPosition)
            {
                RespawnCoin();
            }
        }
        
        private void RespawnCoin()
        {
            Coin.Top = GameConstants.CoinRespawnHeight;
            Coin.Left = new Random().Next(150, 560);
        }
        
        private void CheckCollisions()
        {
            if (CollisionDetector.CheckCollision(Player, Opponent1) || 
                CollisionDetector.CheckCollision(Player, Opponent2))
            {
                HandleGameOver();
            }
        }
        
        private void HandleGameOver()
        {
            Timer.Enabled = false;
            Lose.Visible = true;
            Restart.Visible = true;
            Pause.Visible = false;
            lose = true;
            LogMenuButton.Visible = true;
            SaveRecord();
            ShowRecordsButton.Visible = true;
            _player.Stop();
        }
        
        private void HandleCoinCollection()
        {
            if (CollisionDetector.CheckCollision(Player, Coin))
            {
                coins++;
                Score.Text = $"Score: {coins}";
                if (coins % 10 == 0)
                {
                    level++;
                    Level.Text = $"Рівень: {level}";
                }
                RespawnCoin();
            }
        }
        
        private void SaveRecord()
        {
            if (lose)
            {
                string playerName = "";
                while (string.IsNullOrWhiteSpace(playerName))
                {
                    playerName = Prompt.ShowDialog("Введіть ім'я", "New Record!");
                    if (string.IsNullOrWhiteSpace(playerName))
                    {
                        MessageBox.Show("Рекорд не збережено!.\nБудь ласка, введіть ваше ім'я!", "Error");
                    }
                }
                var existingRecord = records.FirstOrDefault(r => r.PlayerName == playerName);
                if (existingRecord != null)
                {
                    if (coins > existingRecord.Score)
                    {
                        existingRecord.Score = coins;
                    }
                }
                else
                {
                    records.Add(new Record(playerName, coins));
                }
                records = records.OrderByDescending(r => r.Score).Take(10).ToList();
                RecordsManager.SaveRecords(records);
            }
        }
        
        private void ShowRecordsButton_Click(object sender, EventArgs e)
        {
            ShowRecords();
        }

        private void ShowRecords()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name       Score");
            foreach (var record in records)
            {
                sb.AppendLine($"{record.PlayerName}            {record.Score}");
            }
            MessageBox.Show(sb.ToString(), "Records");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speed = 13;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Player.Left > 150)
                Player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Player.Right < 700)
                Player.Left += speed;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Black;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Pause.Visible = true;
            Start.Visible = false;
            Timer.Enabled = true;
            LogMenuButton.Visible = false;
            ShowRecordsButton.Visible = false;
            _player.PlayLooping();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Pause.Visible = false;
            Start.Visible = true;
            LogMenuButton.Visible = true;
            Timer.Enabled = false;
            ShowRecordsButton.Visible = true;
            _player.Stop();
        }

        public int X { get; set; }
        public int Y { get; set; }

        public struct MyPoint
        {
            public int X { get; set; }
            public int Y { get; set; }

            public MyPoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        MyPoint LastPoint;

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - LastPoint.X;
                int deltaY = e.Y - LastPoint.Y;

                this.Left += deltaX;
                this.Top += deltaY;

                LastPoint = new MyPoint(e.X, e.Y);
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LastPoint = new MyPoint(e.X, e.Y);
            }
        }

        private void LogMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Repeat_Click(object sender, EventArgs e)
        {
            Opponent1.Top = -130;
            Opponent2.Top = -400;
            Lose.Visible = false;
            Restart.Visible = false;
            Timer.Enabled = true;
            lose = false;
            coins = 0;
            level = 1;
            Score.Text = "Score:0";
            Level.Text = "Рівень: 1";
            Coin.Top = -500;
            Pause.Visible = true;
            Start.Visible = false;
            LogMenuButton.Visible = false;
            ShowRecordsButton.Visible = false;
            _player.PlayLooping();
        }
        private void StopMusic()
        {
            if (_player != null)
            {
                _player.Stop();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMusic();
        }
    }
}