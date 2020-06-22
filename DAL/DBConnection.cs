using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace CoPoleci.DAL
{
    class DBConnection // klasa typu singleton odpowiadająca za łączenie aplikacji z bazą danych
    {
        private static MySqlConnectionStringBuilder stringBuilder;
        private static string Nickname { get; set; } = "root";
        private static string Password { get; set; } = "";
        public static DBConnection Instance
        {
            get => new DBConnection();
        }

        public MySqlConnection Connection => new MySqlConnection(stringBuilder.ToString());

        // przy rejestracji - domyślnie na roota, który ma prawo do tworzenia użytkownika:
        private DBConnection()
        {
            stringBuilder = new MySqlConnectionStringBuilder
            {
                UserID = Nickname,
                Password = Password,
                Server = "localhost",
                Database = "swiat", //zmienic na "copoleci", gdy już będzie gotowa baza
                Port = 3306
            };
        }

        // przy logowaniu - na własne konto:
        public static void Login(string user, string password)
        {
            Nickname = user; Password = password;
        }

        public void printBuilder() => Debug.Write(stringBuilder.ToString()); // do testowania
    }
}