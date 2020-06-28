namespace CoPoleci
{
    public class TabManager
    {
        private static ActorsTab actors = null;
        private static CompaniesTab companies = null;
        private static DirectorsTab directors = null;
        private static MovieRankings ranking = null;
        private static MoviesTab movies = null;
        private static SeenMoviesTab seenmovies = null;

        public static SeenMoviesTab SeenMovies
        {
            get
            {
                if (seenmovies == null) seenmovies = new SeenMoviesTab();
                return seenmovies;
            }
        }

        public static MoviesTab Movies 
        {
            get
            {
                if (movies == null) movies = new MoviesTab();
                return movies;
            }
        }

        public static ActorsTab Actors
        {
            get
            {
                if (actors == null) actors = new ActorsTab();
                return actors;
            }
        }

        public static DirectorsTab Directors
        {
            get
            {
                if (directors == null) directors = new DirectorsTab();
                return directors;
            }
        }

        public static CompaniesTab Companies
        {
            get
            {
                if (companies == null) companies = new CompaniesTab();
                return companies;
            }
        }
        
        public static MovieRankings Ranking
        {
            get
            {
                if (ranking == null) ranking = new MovieRankings();
                return ranking;
            }
        }
    }
}