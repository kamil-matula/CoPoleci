using System.Collections.Generic;

namespace CoPoleci.DAL
{
    class QueryManager // Klasa zawierająca wyniki zapytań
    {
        public List<Country> Countries { get => CountryRepo.GetAllCountries(); }
        public static List<User> Users { get => UserRepo.GetAllUsers(); }
        public static List<Actor> Actors { get => ActorRepo.GetAllActors(); }
        public static List<Director> Directors { get => DirectorRepo.GetAllDirectors(); }
        public static List<Movie> Movies { get => MovieRepo.GetAllMovies(); }
        public static List<Company> Companies { get => CompanyRepo.GetAllCompanies(); }
    }
}