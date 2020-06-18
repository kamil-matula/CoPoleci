using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class DBConnection
    {
        private MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
        private static DBConnection instance = null;
        public static DBConnection Instance
        {
            get => instance ?? new DBConnection();
        }

        public MySqlConnection Connection => new MySqlConnection(stringBuilder.ToString());

        private DBConnection()
        {
            stringBuilder = new MySqlConnectionStringBuilder
            {
                UserID = "root",
                Password = "",
                Server = "localhost",
                Database = "swiat",
                Port = 3306
            };
        }
    }
}