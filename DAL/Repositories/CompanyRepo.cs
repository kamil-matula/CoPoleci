using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoPoleci.DAL
{
    internal class CompanyRepo
    {
        public static List<Company> GetAllCompanies()
        {
            List<Company> companies = new List<Company>();
            try
            {
                using (MySqlConnection connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand("select * from wytwórnie", connection);
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        companies.Add(new Company(dataReader));
                    connection.Close();
                }
            }
            catch { }
            return companies;
        }

        public static Company GetCompanyFromMovie(Movie movie)
        {
            string company = "";
            try
            {
                using (MySqlConnection connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"select nazwa_wytwórni from wyprodukował where id_filmu = '{movie.Id}'", connection);
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                        company = dataReader["nazwa_wytwórni"].ToString();
                    connection.Close();
                }
            }
            catch { }
 
            return QueryManager.Companies.Find(i => i.Name == company);
        }
    }
}
