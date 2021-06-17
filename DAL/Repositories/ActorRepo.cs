using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    internal class ActorRepo
    {
        public static List<Actor> GetAllActors()
        {
            List<Actor> actors = new List<Actor>();
            try
            {
                using (MySqlConnection connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand("select * from aktorzy", connection);
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        actors.Add(new Actor(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return actors;
        }

        public static List<Actor> GetActorsFromMovie(Movie movie)
        {
            List<int> ids = new List<int>();
            try
            {
                using (MySqlConnection connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"select id_aktora from grał_w where id_filmu = '{movie.Id}'", connection);
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        ids.Add((ushort)dataReader["id_aktora"]);
                    connection.Close();
                }
            }
            catch { }

            List<Actor> allactors = QueryManager.Actors;
            List<Actor> thismovieactors = new List<Actor>();
            foreach (int id in ids)
                thismovieactors.Add(allactors[id - 1]);

            return thismovieactors;
        }
    }
}
