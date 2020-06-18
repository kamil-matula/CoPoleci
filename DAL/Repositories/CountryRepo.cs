using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    public class CountryRepo
    {
        private const string ALL_COUNTRY_QUERY = "SELECT * FROM country";

        public static List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_COUNTRY_QUERY, connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        countries.Add(new Country(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return countries;
        }
    }
}
