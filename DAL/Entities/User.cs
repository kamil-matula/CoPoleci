using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class User
    {
        public string UserID { get; private set; }
        public string Password { get; private set; }

        public User(MySqlDataReader dataReader)
        {
            UserID = dataReader["login"].ToString();
            Password = dataReader["hasło"].ToString();
        }
    }
}