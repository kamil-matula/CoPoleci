using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL.Repositories
{
    class ActorRepo
    {
        private const string ALL_ACTORS_QUERY = "select * from actors";

        public static List<Actor> GetAllActors()
        {
            List<Actor> actors = new List<Actor>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_ACTORS_QUERY, connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        actors.Add(new Actor(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return actors;
        }
    }
}
