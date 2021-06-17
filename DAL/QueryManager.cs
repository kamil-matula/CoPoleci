using System.Collections.Generic;

namespace CoPoleci.DAL
{
    public class QueryManager // Klasa zawierająca wyniki zapytań
    {
        private static List<Actor> actors = null;
        private static List<Director> directors = null;
        private static List<Movie> movies = null;
        private static List<Company> companies = null;

        public static List<Actor> Actors 
        {
            get
            {
                if (actors == null) actors = ActorRepo.GetAllActors();
                return actors;
            }
        }

        public static List<Director> Directors 
        {
            get
            {
                if (directors == null) directors = DirectorRepo.GetAllDirectors();
                return directors;
            }
        }

        public static List<Movie> Movies 
        {
            get
            {
                if (movies == null) movies = MovieRepo.GetAllMovies();
                return movies;
            }
        }

        public static List<Company> Companies 
        {
            get 
            {
                if (companies == null) companies = CompanyRepo.GetAllCompanies();
                return companies;
            } 
        }

        public static List<User> Users { get => UserRepo.GetAllUsers(); }

        public static List<Movie> SeenMovies { get => MovieRepo.GetSeenMovies(); }
    }
}
