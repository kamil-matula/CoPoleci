using System;
using System.Collections.Generic;
using System.Linq;

namespace CoPoleci
{
    class KNN
    {
        private readonly int k;
        private readonly Movie[] movieBase;
        private readonly Movie idealMovie;
        private double[] distances;

        public KNN(int k, Movie[] movieBase, Movie idealMovie)
        {
            this.k = k;
            this.movieBase = movieBase;
            this.idealMovie = idealMovie;
        }

        // Obliczanie metryki Manhattan
        private void CalculateManhattan()
        {
            double[] d = new double[movieBase.Length];
            for (int i = 0; i < movieBase.Length; i++)
            {
                d[i] = Math.Abs(movieBase[i].X_fun - idealMovie.X_fun) + Math.Abs(movieBase[i].X_real - idealMovie.X_real) +
                    Math.Abs(movieBase[i].X_age - idealMovie.X_age) + Math.Abs(movieBase[i].X_emo - idealMovie.X_emo) +
                    Math.Abs(movieBase[i].X_ambit - idealMovie.X_ambit) + Math.Abs(movieBase[i].X_action - idealMovie.X_action) +
                    Math.Abs(movieBase[i].X_romance - idealMovie.X_romance) + Math.Abs(movieBase[i].X_music - idealMovie.X_music) +
                    Math.Abs(movieBase[i].X_criticrate - idealMovie.X_criticrate) + Math.Abs(movieBase[i].X_scary - idealMovie.X_scary);
            }
            distances = d;
        }
        
        // Tworzenie slownika z najblizszymi sasiadami, gdzie kluczem jest indeks "sasiada", 
        // a wartoscia wyliczona wczesniej metryka manhattan
        private Dictionary<int, double> FindNearestNeighbours()
        {
            Dictionary<int, double> nearestneighbours = new Dictionary<int, double>();
            for (int i = 0; i < k; i++) nearestneighbours.Add(i, distances[i]);
            for (int j = k; j < distances.Length; j++)
            {
                double max = nearestneighbours.Max(kvp => kvp.Value);
                if (distances[j] < max)
                {
                    var item = nearestneighbours.First(kvp => kvp.Value == max);
                    nearestneighbours.Remove(item.Key);
                    nearestneighbours.Add(j, distances[j]);
                }
            }
            return nearestneighbours;
        }

        // Wybor filmow
        public List<string> MakeDecision()
        {
            CalculateManhattan();
            var result = FindNearestNeighbours();
            List<string> wyniki = new List<string>();
            foreach (var res in result)
                wyniki.Add(movieBase[res.Key].Title);
            return wyniki;
        }
    }
}