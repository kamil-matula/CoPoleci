using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    internal class DirectorRepo
    {
        public static List<Director> GetAllDirectors()
        {
            List<Director> directors = new List<Director>();
            try
            {
                using (MySqlConnection connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand("select * from reżyserzy", connection);
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        directors.Add(new Director(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return directors;
        }

        public static List<Director> GetDirectorsFromMovie(Movie movie)
        {
            List<int> ids = new List<int>();
            try
            {
                using (MySqlConnection connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"select id_reżysera from wyreżyserował where id_filmu = '{movie.Id}'", connection);
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        ids.Add((ushort)dataReader["id_reżysera"]);
                    connection.Close();
                }
            }
            catch { }

            List<Director> alldirectors = QueryManager.Directors;
            List<Director> thismoviedirectors = new List<Director>();
            foreach (int id in ids)
                thismoviedirectors.Add(alldirectors[id - 1]);

            return thismoviedirectors;
        }
    }
}
