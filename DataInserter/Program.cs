using System.IO;
using MySql.Data.MySqlClient;

namespace DataInserter
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder connStrBuilder = new MySqlConnectionStringBuilder
            {
                UserID = "root",
                Password = "",
                Server = "localhost",
                Database = "CoPoleci",
                Port = 3306
            };

            string[] lines = File.ReadAllLines(args[0]);
            int attrNumber = lines[0].Split(",").Length;
            using (var connection = new MySqlConnection(connStrBuilder.ToString()))
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    MySqlCommand command = new MySqlCommand($"INSERT INTO {args[1]} VALUES {PrepareString(lines[i], attrNumber)}", connection);
                    connection.Open();
                    _ = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        static string PrepareString(string line, int attrNumber)
        {
            string tmp = "(";
            string[] values = line.Split(",");
            for (int j = 0; j < attrNumber - 1; j++)
                tmp += $"'{values[j]}', ";
            tmp += $"'{values[attrNumber - 1]}')";
            return tmp;
        }
    }
}