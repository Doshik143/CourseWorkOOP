using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_Робота
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=coursework1");
        public void OpenConnection()
        {
            OpensConnectionIfItsClose();
        }

        public void CloseConnection()
        {
            ClosesConnectionIfItsOpen();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        private void OpensConnectionIfItsClose()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        private void ClosesConnectionIfItsOpen()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
