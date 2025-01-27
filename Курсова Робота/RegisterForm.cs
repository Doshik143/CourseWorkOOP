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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            NameLine.Text = "Введіть ім'я";
            NameLine.ForeColor = Color.Gray;

            Surname.Text = "Введіть прізвище";
            Surname.ForeColor = Color.Gray;

            Login.Text = "Введіть логін";
            Login.ForeColor = Color.Gray;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameLine_Enter(object sender, EventArgs e)
        {
            if (NameLine.Text == "Введіть ім'я")
            {
                NameLine.Text = "";
                NameLine.ForeColor = Color.Black;
            }
        }

        private void NameLine_Leave(object sender, EventArgs e)
        {
            if (NameLine.Text == "")
            {
                NameLine.Text = "Введіть ім'я";
                NameLine.ForeColor = Color.Gray;
            }
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Введіть прізвище")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Введіть прізвище";
                Surname.ForeColor = Color.Gray;
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введіть логін")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введіть логін";
                Login.ForeColor = Color.Gray;
            }
        }
        private void Registration_Click(object sender, EventArgs e)
        {
            if (NameLine.Text == "Введіть ім'я")
            {
                MessageBox.Show("Введіть ім'я!");
                return;
            }

            if (Surname.Text == "Введіть прізвище")
            {
                MessageBox.Show("Введіть прізвище!");
                return;
            }

            if (Login.Text == "Введіть логін")
            {
                MessageBox.Show("Введіть логін!");
                return;
            }

            if (Password.Text == "")
            {
                MessageBox.Show("Введіть пароль!");
                return;
            }

            if (IsUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Login`, `Password`, `Name`, `Surname`) VALUES (@login, @password, @name, @surname)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameLine.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Surname.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Акаунт успішно створено!\nДякуємо за реєстрацію!");
            else
                MessageBox.Show("Не вдалося створити акаунт :(\nСпробуйте ще раз!");

            db.CloseConnection();
        }

        public Boolean IsUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @UL", db.GetConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = Login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий користувач вже існує!\nВведіть інший логін!");
                return true;
            }
            else
                return false;
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LoginLink_MouseEnter(object sender, EventArgs e)
        {
            LoginLink.ForeColor = Color.Gray;
        }

        private void LoginLink_MouseLeave(object sender, EventArgs e)
        {
            LoginLink.ForeColor = Color.White;
        }
    }
}
