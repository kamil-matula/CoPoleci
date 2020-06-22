using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class MovieRepo
    {
        private const string ALL_MOVIES_QUERY = "SELECT * FROM MOVIES";

        public static List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_MOVIES_QUERY, connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        movies.Add(new Movie(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return movies;
        }
    }
}