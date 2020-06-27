using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace CoPoleci.DAL.Repositories
{
    class MovieRepo
    {
        private const string ALL_MOVIES_QUERY = "select * from filmy";

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

        public static List<Movie> GetSeenMovies()
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"select * from filmy where id in " +
                        $"(select id_filmu from obejrzane where nick = '{DBConnection.Nickname}')", connection);
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

        public bool AddToSeen(Movie movie, string rate)
        {
            bool state = false;
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"insert obejrzane value ('{DBConnection.Nickname}', '{movie.Id}', '{rate}', '{DateTime.Today}')", connection);
                    connection.Open();
                    _= command.ExecuteNonQuery();
                    state = true;
                    connection.Close();
                }
            }
            catch { }
            return state;
        }
    }
}