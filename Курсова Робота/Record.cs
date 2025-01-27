using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_Робота
{
    [Serializable]
    public class Record
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public Record(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }
    }
}
