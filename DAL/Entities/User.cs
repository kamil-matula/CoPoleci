using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }

        public User(MySqlDataReader dataReader)
        {
            UserID = dataReader["nickname"].ToString();
            Password = dataReader["password"].ToString();
        }
    }
}