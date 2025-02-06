using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_Робота
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Password.AutoSize = false;
            this.Password.Size = new Size(this.Password.Size.Width, 64);
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
            Exit.ForeColor = Color.White;
        }
        Point lastPoint;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Up_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Up_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Login_click_Click(object sender, EventArgs e)
        {
            String LogUser = Login.Text;
            String PassUser = Password.Text;
            DataTable table;
            MySqlDataAdapter adapter;
            MySqlCommand command;
            ConnectWithDB(LogUser, PassUser, out table, out adapter, out command);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            UserAuthorization(table);
        }

        private void RegistrationLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void RegistrationLink_MouseEnter(object sender, EventArgs e)
        {
            RegistrationLink.ForeColor = Color.Gray;
        }

        private void RegistrationLink_MouseLeave(object sender, EventArgs e)
        {
            RegistrationLink.ForeColor = Color.White;
        }

        private void UserAuthorization(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                this.Hide();
                Form1 game = new Form1();
                game.Show();
            }
            else
                MessageBox.Show("На жаль, користувача не знайдено :(\nПовторіть спробу!");
        }

        private static void ConnectWithDB(string LogUser, string PassUser, out DataTable table, out MySqlDataAdapter adapter, out MySqlCommand command)
        {
            DB db = new DB();

            table = new DataTable();
            adapter = new MySqlDataAdapter();
            command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @UL AND `Password` = @UP", db.GetConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = LogUser;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = PassUser;
        }
    }
}
