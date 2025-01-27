namespace Курсова_Робота
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Road = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Opponent1 = new System.Windows.Forms.PictureBox();
            this.Opponent2 = new System.Windows.Forms.PictureBox();
            this.Lose = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.Level = new System.Windows.Forms.Label();
            this.LogMenuButton = new System.Windows.Forms.Button();
            this.ShowRecordsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Road
            // 
            this.Road.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Road.BackgroundImage")));
            this.Road.Location = new System.Drawing.Point(0, 0);
            this.Road.Name = "Road";
            this.Road.Size = new System.Drawing.Size(825, 650);
            this.Road.TabIndex = 0;
            this.Road.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(315, 429);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(70, 170);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 15;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Road2
            // 
            this.Road2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Road2.BackgroundImage")));
            this.Road2.Location = new System.Drawing.Point(0, -650);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(824, 650);
            this.Road2.TabIndex = 2;
            this.Road2.TabStop = false;
            // 
            // Opponent1
            // 
            this.Opponent1.BackColor = System.Drawing.Color.Transparent;
            this.Opponent1.Image = ((System.Drawing.Image)(resources.GetObject("Opponent1.Image")));
            this.Opponent1.Location = new System.Drawing.Point(212, -130);
            this.Opponent1.Name = "Opponent1";
            this.Opponent1.Size = new System.Drawing.Size(70, 170);
            this.Opponent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opponent1.TabIndex = 3;
            this.Opponent1.TabStop = false;
            // 
            // Opponent2
            // 
            this.Opponent2.BackColor = System.Drawing.Color.Transparent;
            this.Opponent2.Image = ((System.Drawing.Image)(resources.GetObject("Opponent2.Image")));
            this.Opponent2.Location = new System.Drawing.Point(599, -400);
            this.Opponent2.Name = "Opponent2";
            this.Opponent2.Size = new System.Drawing.Size(70, 170);
            this.Opponent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opponent2.TabIndex = 4;
            this.Opponent2.TabStop = false;
            // 
            // Lose
            // 
            this.Lose.AutoSize = true;
            this.Lose.BackColor = System.Drawing.Color.Transparent;
            this.Lose.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lose.ForeColor = System.Drawing.Color.Crimson;
            this.Lose.Location = new System.Drawing.Point(207, 129);
            this.Lose.Name = "Lose";
            this.Lose.Size = new System.Drawing.Size(430, 82);
            this.Lose.TabIndex = 5;
            this.Lose.Text = "Game Over";
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Restart.BackgroundImage")));
            this.Restart.Image = ((System.Drawing.Image)(resources.GetObject("Restart.Image")));
            this.Restart.Location = new System.Drawing.Point(293, 214);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(80, 80);
            this.Restart.TabIndex = 6;
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.Transparent;
            this.Coin.Image = ((System.Drawing.Image)(resources.GetObject("Coin.Image")));
            this.Coin.Location = new System.Drawing.Point(435, -600);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(32, 32);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 7;
            this.Coin.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Playbill", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Location = new System.Drawing.Point(3, 2);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(81, 38);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score:0";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(791, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(293, 214);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 80);
            this.Start.TabIndex = 10;
            this.Start.Text = "►";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(772, 45);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(40, 40);
            this.Pause.TabIndex = 11;
            this.Pause.Text = "||";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Level);
            this.Panel.Controls.Add(this.Score);
            this.Panel.Controls.Add(this.Exit);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(824, 39);
            this.Panel.TabIndex = 12;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Playbill", 27.75F);
            this.Level.ForeColor = System.Drawing.Color.Firebrick;
            this.Level.Location = new System.Drawing.Point(90, 2);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(91, 38);
            this.Level.TabIndex = 10;
            this.Level.Text = "Level: 1";
            // 
            // LogMenuButton
            // 
            this.LogMenuButton.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogMenuButton.ForeColor = System.Drawing.Color.DarkRed;
            this.LogMenuButton.Location = new System.Drawing.Point(379, 214);
            this.LogMenuButton.Name = "LogMenuButton";
            this.LogMenuButton.Size = new System.Drawing.Size(80, 80);
            this.LogMenuButton.TabIndex = 13;
            this.LogMenuButton.Text = "Exit";
            this.LogMenuButton.UseVisualStyleBackColor = true;
            this.LogMenuButton.Click += new System.EventHandler(this.LogMenuButton_Click);
            // 
            // ShowRecordsButton
            // 
            this.ShowRecordsButton.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRecordsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ShowRecordsButton.Location = new System.Drawing.Point(465, 214);
            this.ShowRecordsButton.Name = "ShowRecordsButton";
            this.ShowRecordsButton.Size = new System.Drawing.Size(80, 80);
            this.ShowRecordsButton.TabIndex = 14;
            this.ShowRecordsButton.Text = "Records";
            this.ShowRecordsButton.UseVisualStyleBackColor = true;
            this.ShowRecordsButton.Click += new System.EventHandler(this.ShowRecordsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.ShowRecordsButton);
            this.Controls.Add(this.LogMenuButton);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Lose);
            this.Controls.Add(this.Opponent2);
            this.Controls.Add(this.Opponent1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Road);
            this.Controls.Add(this.Road2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Road;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox Opponent1;
        private System.Windows.Forms.PictureBox Opponent2;
        private System.Windows.Forms.Label Lose;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button LogMenuButton;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button ShowRecordsButton;
    }
}

