using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова_Робота
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        private Point _lastPoint;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();

            Password.AutoSize = false;
            Password.Size = new Size(Password.Size.Width, 64);
        }

        private void Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void Exit_MouseEnter(object sender, EventArgs e) => Exit.ForeColor = Color.Red;

        private void Exit_MouseLeave(object sender, EventArgs e) => Exit.ForeColor = Color.White;

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _lastPoint.X;
                Top += e.Y - _lastPoint.Y;
            }
        }

        private void CaptureMousePosition(object sender, MouseEventArgs e) => _lastPoint = new Point(e.X, e.Y);

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Login.Text;
            string password = Password.Text;

            if (_authService.AuthenticateUser(username, password))
            {
                Hide();
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("На жаль, користувача не знайдено :(\nПовторіть спробу!");
            }
        }

        private void RegistrationLink_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterForm().Show();
        }

        private void RegistrationLink_MouseEnter(object sender, EventArgs e) => RegistrationLink.ForeColor = Color.Gray;

        private void RegistrationLink_MouseLeave(object sender, EventArgs e) => RegistrationLink.ForeColor = Color.White;
    }

    public class AuthService
    {
        public bool AuthenticateUser(string username, string password)
        {
            using (DB db = new DB()) 
            {
                var query = "SELECT COUNT(*) FROM users WHERE Login = @username AND Password = @password";
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    db.OpenConnection();
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    db.CloseConnection();

                    return userCount > 0;
                }
            }
        }
    }
}
