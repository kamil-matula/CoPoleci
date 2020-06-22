using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    class CompanyRepo
    {
        private const string ALL_COMPANIES_QUERY = "SELECT * FROM COMPANIES";

        public static List<Company> GetAllCompanies()
        {
            List<Company> companies = new List<Company>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_COMPANIES_QUERY, connection);
                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        companies.Add(new Company(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return companies;
        }
    }
}
