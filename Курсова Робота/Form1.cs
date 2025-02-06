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
            int speed = 10;
            Road.Top += speed;
            Road2.Top += speed;
            int carspeed = 7;
            Opponent1.Top += carspeed;
            Opponent2.Top += carspeed;
            int cointime = 7;
            Coin.Top += cointime;
            RandEmersionCoin();
            RoadAnimation();
            RandEmersionOpponent1();
            RandEmersionOpponent2();
            PlayerBounseLose();
            PlayerCollectCoin();
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
        private void SaveRecord()
        {
            if (lose)
            {
                string playerName = "";
                playerName = CreateNameForRecord(playerName);
                Record existingRecord = CheckExistenceRecord(playerName);
                UpdateOrAddNewRecord(playerName, existingRecord);
                SortOrSaveTopTenRecords();
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
            PresentRecordsTable(sb);
            MessageBox.Show(sb.ToString(), "Records");
        }

        private void StopMusic()
        {
            StopMusicIfLose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMusic();
        }

        private void PlayerCollectCoin()
        {
            if (Player.Bounds.IntersectsWith(Coin.Bounds))
            {
                coins++;
                Score.Text = "Score:" + coins.ToString();
                if (coins % 10 == 0)
                {
                    level++;
                    Level.Text = "Рівень: " + level.ToString();
                }
                Coin.Top = -50;
                Random rand = new Random();
                Coin.Left = rand.Next(150, 560);
            }
        }

        private void PlayerBounseLose()
        {
            if (Player.Bounds.IntersectsWith(Opponent1.Bounds) || Player.Bounds.IntersectsWith(Opponent2.Bounds))
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
        }

        private void RandEmersionOpponent2()
        {
            if (Opponent2.Top >= 650)
            {
                Opponent2.Top = -400;
                Random rand = new Random();
                Opponent2.Left = rand.Next(301, 560);
            }
        }

        private void RandEmersionOpponent1()
        {
            if (Opponent1.Top >= 650)
            {
                Opponent1.Top = -130;
                Random rand = new Random();
                Opponent1.Left = rand.Next(150, 299);
            }
        }

        private void RoadAnimation()
        {
            if (Road.Top >= 650)
            {
                Road.Top = 0;
                Road2.Top = -650;
            }
        }

        private void RandEmersionCoin()
        {
            if (Coin.Top >= 650)
            {
                Coin.Top = -50;
                Random rand = new Random();
                Coin.Left = rand.Next(150, 560);
            }
        }

        private void SortOrSaveTopTenRecords()
        {
            records = records.OrderByDescending(r => r.Score).Take(10).ToList();
        }

        private void UpdateOrAddNewRecord(string playerName, Record existingRecord)
        {
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
        }

        private Record CheckExistenceRecord(string playerName)
        {
            return records.FirstOrDefault(r => r.PlayerName == playerName);
        }

        private static string CreateNameForRecord(string playerName)
        {
            while (string.IsNullOrWhiteSpace(playerName))
            {
                playerName = Prompt.ShowDialog("Введіть імя", "New Record!");
                if (string.IsNullOrWhiteSpace(playerName))
                {
                    MessageBox.Show("Рекорд не збережено!.\nБудь ласка, введіть ваше імя!", "Error");
                }
            }

            return playerName;
        }

        private void PresentRecordsTable(StringBuilder sb)
        {
            sb.AppendLine("Name       Score");
            foreach (var record in records)
            {
                sb.AppendLine($"{record.PlayerName}            {record.Score}");
            }
        }

        private void StopMusicIfLose()
        {
            if (_player != null)
            {
                _player.Stop();
            }
        }
    }
}