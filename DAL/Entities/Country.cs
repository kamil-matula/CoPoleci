using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(MySqlDataReader dataReader)
        {
            Code = dataReader["code"].ToString();
            Name = dataReader["name"].ToString();
            Population = (int)dataReader["population"];
        }

        public override string ToString()
        {
            return $"{Name} {Code} {Population}";
        }
    }
}