using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class DirectorRepo
    {
        private const string ALL_DIRECTORS_QUERY = "select * from reżyserzy";

        public static List<Director> GetAllDirectors()
        {
            List<Director> directors = new List<Director>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_DIRECTORS_QUERY, connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        directors.Add(new Director(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return directors;
        }
    }
}