using MySql.Data.MySqlClient;
using System.IO;

namespace CoPoleci.DAL
{
    class DBConnection // klasa odpowiadająca za łączenie aplikacji z bazą danych
    {
        #region Właściwości
        private static MySqlConnectionStringBuilder stringBuilder;
        public static string Nickname { get; private set; } 
        private static string Password { get; set; }
        private static string Server { get; set; }
        private static string Database { get; set; }
        private static uint Port { get; set; }
        public static DBConnection Instance
        {
            get => new DBConnection();
        }
        public MySqlConnection Connection => new MySqlConnection(stringBuilder.ToString());
        #endregion

        private DBConnection()
        {
            stringBuilder = new MySqlConnectionStringBuilder
            {
                UserID = Nickname,
                Password = Password,
                Server = Server,
                Database = Database,
                Port = Port,
                CharacterSet = "utf8"
            };
        }

        // logowanie poprzedza podmiana zmiennych nickname i password:
        public static void Login(string user, string password)
        {
            Nickname = user; Password = password;
        }

        // w procesie rejestracji oraz przy sprawdzaniu poprawności logowania wykorzystywany jest root:
        public static bool LoginAsRoot(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length != 5) return false;
                Nickname = lines[0]; Password = lines[1]; 
                Server = lines[2]; Database = lines[3]; 
                Port = uint.Parse(lines[4]);
                return true;
            }
            catch { return false; }
        }
    }
}