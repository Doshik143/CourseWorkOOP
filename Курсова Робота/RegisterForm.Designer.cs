namespace Курсова_Робота
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Main = new System.Windows.Forms.Panel();
            this.LoginLink = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.NameLine = new System.Windows.Forms.TextBox();
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
            this.Main.Controls.Add(this.LoginLink);
            this.Main.Controls.Add(this.Login);
            this.Main.Controls.Add(this.Surname);
            this.Main.Controls.Add(this.Registration);
            this.Main.Controls.Add(this.pictureBox2);
            this.Main.Controls.Add(this.Password);
            this.Main.Controls.Add(this.NameLine);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.Up);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.MaximumSize = new System.Drawing.Size(824, 611);
            this.Main.MinimumSize = new System.Drawing.Size(824, 611);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(824, 611);
            this.Main.TabIndex = 1;
            this.Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLink.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginLink.Location = new System.Drawing.Point(374, 483);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(89, 13);
            this.LoginLink.TabIndex = 7;
            this.LoginLink.Text = "Авторизуватись";
            this.LoginLink.Click += new System.EventHandler(this.LoginLink_Click);
            this.LoginLink.MouseEnter += new System.EventHandler(this.LoginLink_MouseEnter);
            this.LoginLink.MouseLeave += new System.EventHandler(this.LoginLink_MouseLeave);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(94, 264);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(293, 44);
            this.Login.TabIndex = 7;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(504, 155);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(293, 44);
            this.Surname.TabIndex = 6;
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // Registration
            // 
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.Registration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Niagara Engraved", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registration.Location = new System.Drawing.Point(272, 404);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(289, 40);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Створити акаунт";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(504, 264);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(293, 44);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // NameLine
            // 
            this.NameLine.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLine.Location = new System.Drawing.Point(94, 155);
            this.NameLine.Name = "NameLine";
            this.NameLine.Size = new System.Drawing.Size(293, 44);
            this.NameLine.TabIndex = 2;
            this.NameLine.Enter += new System.EventHandler(this.NameLine_Enter);
            this.NameLine.Leave += new System.EventHandler(this.NameLine_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 253);
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
            this.Up.Size = new System.Drawing.Size(824, 61);
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
            this.Exit.Location = new System.Drawing.Point(782, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
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
            this.label1.Size = new System.Drawing.Size(271, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕЄСТРАЦІЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(824, 611);
            this.MinimumSize = new System.Drawing.Size(824, 611);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
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
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox NameLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Up;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LoginLink;
    }
}