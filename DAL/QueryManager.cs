using System.Collections.Generic;

namespace CoPoleci.DAL
{
    using CoPoleci.DAL.Repositories;
    class QueryManager // Klasa zawierająca wyniki zapytań
    {
        private static List<Country> countries = null;
        private static List<Actor> actors = null;
        private static List<Director> directors = null;
        private static List<Movie> movies = null;
        private static List<Company> companies = null;

        public List<Country> Countries
        {
            get
            {
                if (countries == null) countries = CountryRepo.GetAllCountries();
                return countries;
            }
        }

        public List<Actor> Actors 
        {
            get
            {
                if (actors == null) actors = ActorRepo.GetAllActors();
                return actors;
            }
        }

        public List<Director> Directors 
        {
            get
            {
                if (directors == null) directors = DirectorRepo.GetAllDirectors();
                return directors;
            }
        }

        public List<Movie> Movies 
        {
            get
            {
                if (movies == null) movies = MovieRepo.GetAllMovies();
                return movies;
            }
        }

        public List<Company> Companies 
        {
            get 
            {
                if (companies == null) companies = CompanyRepo.GetAllCompanies();
                return companies;
            } 
        }

        public static List<User> Users { get => UserRepo.GetAllUsers(); }
    }
}