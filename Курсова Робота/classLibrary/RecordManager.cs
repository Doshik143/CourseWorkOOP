using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_Робота.classLibrary
{
    public class RecordsManager
    {
        private List<Record> records;

        public RecordsManager()
        {
            records = LoadRecords();
        }

        public static List<Record> LoadRecords()
        {
            // діставання з дб
            return new List<Record>();
        }

        public void SaveRecord(int coins)
        {
            string playerName = Prompt.ShowDialog("Введіть ім'я", "New Record!");
            if (!string.IsNullOrWhiteSpace(playerName))
            {
                var existingRecord = records.FirstOrDefault(r => r.PlayerName == playerName);
                if (existingRecord != null && coins > existingRecord.Score)
                {
                    existingRecord.Score = coins;
                }
                else
                {
                    records.Add(new Record(playerName, coins));
                }
                records = records.OrderByDescending(r => r.Score).Take(10).ToList();
                SaveRecords(records);
            }
        }

        public static void SaveRecords(List<Record> records)
        {
            // зберігання в дб
        }
    }
}
