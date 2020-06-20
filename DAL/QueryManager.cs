using System.Collections.Generic;

namespace CoPoleci.DAL
{
    class QueryManager // Klasa zawierająca wyniki zapytań
    {
        public List<Country> Countries { get => CountryRepo.GetAllCountries(); }
        public static List<User> Users { get => UserRepo.GetAllUsers(); }
    }
}