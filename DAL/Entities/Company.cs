using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    public class Company
    {
        public string Name { get; set; }
        public string HeadQuarters { get; set; }
        public int Founded { get; set; }

        public Company(MySqlDataReader dataReader)
        { 
            Name = dataReader["name"].ToString();
            HeadQuarters = dataReader["headquarters"].ToString();
            Founded = (int)dataReader["founded"];
        }

        public override string ToString()
        {
            return $"{Name} {HeadQuarters} {Founded}";
        }
    }
}