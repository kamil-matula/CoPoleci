using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoPoleci
{
    public class TabManager
    {
          public SeenMoviesTab SeenMovies { get; }
          public MoviesTab Movies { get; }
          public ActorsTab Actors { get; }
          public DirectorsTab Directors { get; }
          public CompaniesTab Companies { get; }
          public MovieRankings Ranking { get; }
          
        
        public TabManager()
        {
            SeenMovies = new SeenMoviesTab();
            Movies = new MoviesTab();
            Actors = new ActorsTab();
            Directors = new DirectorsTab();
            Companies = new CompaniesTab();
            Ranking = new MovieRankings();
        }

    }
}
