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
                    MySqlCommand command = new MySqlCommand("select * from użytkownicy", connection);
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
                try
                {
                    MySqlCommand commandcreate = new MySqlCommand($"create user '{UserID}' identified by '{Password}'", connection);
                    MySqlCommand commandgrantselectmovies = new MySqlCommand($"grant select on filmy to '{UserID}'", connection);
                    MySqlCommand commandgrantselectactors = new MySqlCommand($"grant select on aktorzy to '{UserID}'", connection);
                    MySqlCommand commandgrantselectdirectors = new MySqlCommand($"grant select on reżyserzy to '{UserID}'", connection);
                    MySqlCommand commandgrantselectcompanies = new MySqlCommand($"grant select on wytwórnie to '{UserID}'", connection);
                    MySqlCommand commandgrantpriviligesseen = new MySqlCommand($"grant select, insert, delete, update on obejrzane to '{UserID}'", connection);
                    MySqlCommand commandinsertusers = new MySqlCommand($"insert użytkownicy value ('{UserID}', MD5('{Password}'))", connection);
                    MySqlCommand commandgrantselectcountries = new MySqlCommand($"grant select on Country to '{UserID}'", connection);

                    connection.Open();
                    var id1 = commandcreate.ExecuteNonQuery();
                    var id2 = commandgrantselectmovies.ExecuteNonQuery();
                    var id3 = commandgrantselectactors.ExecuteNonQuery();
                    var id4 = commandgrantselectdirectors.ExecuteNonQuery();
                    var id5 = commandgrantselectcompanies.ExecuteNonQuery();
                    var id6 = commandgrantpriviligesseen.ExecuteNonQuery();
                    var id7 = commandinsertusers.ExecuteNonQuery();
                    var id8 = commandgrantselectcountries.ExecuteNonQuery();
                    state = true;
                    connection.Close();
                }
                catch { }
            }
            return state;
        }

        // Wykorzystuje komendę MD5 występującą w języku MySQL, żeby zahashować stringa (i później porównać w procesie logowania):
        public static string HashPassword(string password)
        {
            string hashed = "";
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"select MD5(\"{password}\") PWD", connection);
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