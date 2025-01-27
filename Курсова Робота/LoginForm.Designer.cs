namespace Курсова_Робота
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Main = new System.Windows.Forms.Panel();
            this.RegistrationLink = new System.Windows.Forms.Label();
            this.Login_click = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Up.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(51)))));
            this.Main.Controls.Add(this.RegistrationLink);
            this.Main.Controls.Add(this.Login_click);
            this.Main.Controls.Add(this.pictureBox2);
            this.Main.Controls.Add(this.Password);
            this.Main.Controls.Add(this.Login);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.Up);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.MaximumSize = new System.Drawing.Size(825, 650);
            this.Main.MinimumSize = new System.Drawing.Size(825, 650);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(825, 650);
            this.Main.TabIndex = 0;
            this.Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // RegistrationLink
            // 
            this.RegistrationLink.AutoSize = true;
            this.RegistrationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationLink.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationLink.Location = new System.Drawing.Point(366, 467);
            this.RegistrationLink.Name = "RegistrationLink";
            this.RegistrationLink.Size = new System.Drawing.Size(110, 13);
            this.RegistrationLink.TabIndex = 6;
            this.RegistrationLink.Text = "Не маєш аккаунта? ";
            this.RegistrationLink.Click += new System.EventHandler(this.RegistrationLink_Click);
            this.RegistrationLink.MouseEnter += new System.EventHandler(this.RegistrationLink_MouseEnter);
            this.RegistrationLink.MouseLeave += new System.EventHandler(this.RegistrationLink_MouseLeave);
            // 
            // Login_click
            // 
            this.Login_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_click.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.Login_click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Login_click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Login_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_click.Font = new System.Drawing.Font("Niagara Engraved", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_click.Location = new System.Drawing.Point(272, 404);
            this.Login_click.Name = "Login_click";
            this.Login_click.Size = new System.Drawing.Size(289, 40);
            this.Login_click.TabIndex = 5;
            this.Login_click.Text = "Вхід";
            this.Login_click.UseVisualStyleBackColor = true;
            this.Login_click.Click += new System.EventHandler(this.Login_click_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(161, 255);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(529, 63);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(161, 111);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(529, 64);
            this.Login.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.Up.Controls.Add(this.Exit);
            this.Up.Controls.Add(this.label1);
            this.Up.Dock = System.Windows.Forms.DockStyle.Top;
            this.Up.Location = new System.Drawing.Point(0, 0);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(825, 61);
            this.Up.TabIndex = 0;
            this.Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_MouseDown);
            this.Up.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Up_MouseMove);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(781, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦІЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(824, 611);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(824, 611);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Up.ResumeLayout(false);
            this.Up.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button Login_click;
        private System.Windows.Forms.Label RegistrationLink;
    }
}