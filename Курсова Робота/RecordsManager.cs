using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Курсова_Робота
{
    public static class RecordsManager
    {
        private static BinaryFormatter _bin = new BinaryFormatter();
        private static string filePath = "records.dat";

        public static void SaveRecords(List<Record> records)
        {
            CreateAndSaveListRecords(records);
        }

        public static List<Record> LoadRecords()
        {
            return FindAndLoadListRecords();
        }

        private static List<Record> FindAndLoadListRecords()
        {
            if (!File.Exists(filePath))
            {
                return new List<Record>();
            }

            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                try
                {
                    return (List<Record>)_bin.Deserialize(stream);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
            }
        }

        private static void CreateAndSaveListRecords(List<Record> records)
        {
            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                try
                {
                    _bin.Serialize(stream, records);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }
            }
        }
    }
}
