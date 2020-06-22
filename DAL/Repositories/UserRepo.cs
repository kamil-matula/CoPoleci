using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class UserRepo
    {
        // Wypisuje wszystkich użytkowników (nick + hasło) z tabeli Users:
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM USERS", connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        users.Add(new User(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return users;
        }

        // Tworzy nowego użytkownika i nadaje mu odpowiednie uprawnienia:
        public static bool AddUser(string UserID, string Password)
        {
            bool state = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand commandcreate = new MySqlCommand($"CREATE USER '{UserID}'@'localhost' IDENTIFIED BY '{Password}'", connection);
                MySqlCommand commandgrantselectmovies = new MySqlCommand($"GRANT SELECT ON MOVIES TO '{UserID}'@'localhost'", connection);
                MySqlCommand commandgrantselectactors = new MySqlCommand($"GRANT SELECT ON ACTORS TO '{UserID}'@'localhost'", connection);
                MySqlCommand commandgrantselectdirectors = new MySqlCommand($"GRANT SELECT ON DIRECTORS TO '{UserID}'@'localhost'", connection);
                MySqlCommand commandgrantselectcompanies = new MySqlCommand($"GRANT SELECT ON COMPANIES TO '{UserID}'@'localhost'", connection);
                MySqlCommand commandgrantpriviligesseen = new MySqlCommand($"GRANT SELECT, INSERT, DELETE, UPDATE ON SEEN TO '{UserID}'@'localhost'", connection);
                MySqlCommand commandinsertusers = new MySqlCommand($"INSERT USERS VALUE ('{UserID}', password('{Password}'))", connection);

                connection.Open();
                var id1 = commandcreate.ExecuteNonQuery();
                var id2 = commandgrantselectmovies.ExecuteNonQuery();
                var id3 = commandgrantselectactors.ExecuteNonQuery();
                var id4 = commandgrantselectdirectors.ExecuteNonQuery();
                var id5 = commandgrantselectcompanies.ExecuteNonQuery();
                var id6 = commandgrantpriviligesseen.ExecuteNonQuery();
                var id7 = commandinsertusers.ExecuteNonQuery();
                state = true;
                connection.Close();
            }
            return state;
        }

        // Wykorzystuje komendę PASSWORD występującą w języku MySQL, żeby zahashować stringa (i później porównać w procesie logowania):
        public static string HashPassword(string password)
        {
            string hashed = "";
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"SELECT PASSWORD(\"{password}\") PWD", connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        hashed = dataReader["PWD"].ToString();
                    connection.Close();
                }
            }
            catch { }
            return hashed;
        }
    }
}