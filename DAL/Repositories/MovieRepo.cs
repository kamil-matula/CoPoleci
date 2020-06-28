using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace CoPoleci.DAL
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
            List<int> ids = new List<int>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"select id from filmy where id in " +
                        $"(select id_filmu from obejrzane where nick = '{DBConnection.Nickname}')", connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        ids.Add((byte)dataReader["id"]);
                    connection.Close();
                }
            }
            catch { }

            List<Movie> allmovies = QueryManager.Movies;
            List<Movie> seenmovies = new List<Movie>();
            foreach (int id in ids)
            {
                allmovies[id - 1].WasSeen = true;
                seenmovies.Add(allmovies[id - 1]);
            }            

            return seenmovies;
        }

        public static bool AddToSeen(Movie movie, string rate = "")
        {
            bool state = false;
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"insert obejrzane value ('{DBConnection.Nickname}', '{movie.Id}', '{rate}', '{DateTime.Today.ToShortDateString()}')", connection);
                    connection.Open();
                    _= command.ExecuteNonQuery();
                    state = true;
                    connection.Close();
                }
            }
            catch { }
            return state;
        }

        public static bool RemoveFromSeen(Movie movie)
        {
            bool state = false;
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"delete from obejrzane where nick = '{DBConnection.Nickname}' and id_filmu = '{movie.Id}'", connection);
                    connection.Open();
                    _ = command.ExecuteNonQuery();
                    state = true;
                    connection.Close();
                }
            }
            catch { }
            return state;
        }
    }
}