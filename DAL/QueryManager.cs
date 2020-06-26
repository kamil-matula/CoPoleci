using System.Collections.Generic;

namespace CoPoleci.DAL
{
    using CoPoleci.DAL.Repositories;
    class QueryManager // Klasa zawierająca wyniki zapytań
    {
        private readonly List<Country> countries = null;
        private readonly List<Actor> actors = null;
        private readonly List<Director> directors = null;
        private readonly List<Movie> movies = null;
        private readonly List<Company> companies = null;

        public List<Country> Countries { get => countries ?? CountryRepo.GetAllCountries(); }
        public List<Actor> Actors { get => actors ?? ActorRepo.GetAllActors(); }
        public List<Director> Directors { get => directors ?? DirectorRepo.GetAllDirectors(); }
        public List<Movie> Movies { get => movies ?? MovieRepo.GetAllMovies(); }
        public List<Company> Companies { get => companies ?? CompanyRepo.GetAllCompanies(); }
        public static List<User> Users { get => UserRepo.GetAllUsers(); }
    }
}