using System.Collections.Generic;

namespace CoPoleci.DAL
{
    class QueryManager
    {
        public List<Country> Countries { get => CountryRepo.GetAllCountries(); }
    }
}