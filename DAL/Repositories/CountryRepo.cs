using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL.Repositories
{
    class CountryRepo
    {
        private const string ALL_COUNTRIES_QUERY = "select * from Country";

        public static List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_COUNTRIES_QUERY, connection);
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