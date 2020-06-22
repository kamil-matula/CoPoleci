using System;
using System.IO;

namespace CoPoleci
{
    class DataPrep
    {
        // Pobieranie bazy filmow z pliku
        public static Movie[] Upload(string path)
        {
            string[] lines = File.ReadAllLines(path);
            Movie[] movie = new Movie[lines.Length - 1];

            // Z pominieciem pierwszej linii, gdzie znajduja sie opisy kolumn
            for (int i = 0; i < lines.Length - 1; i++)
            {
                string[] tmp = lines[i + 1].Split(',');
                movie[i] = new Movie
                {
                    Title = tmp[0],
                    X_fun = Convert.ToDouble(tmp[1].Replace('.', ',')),
                    X_real = Convert.ToDouble(tmp[2].Replace('.', ',')),
                    X_age = Convert.ToDouble(tmp[3].Replace('.', ',')),
                    X_emo = Convert.ToDouble(tmp[4].Replace('.', ',')),
                    X_ambit = Convert.ToDouble(tmp[5].Replace('.', ',')),
                    X_action = Convert.ToDouble(tmp[6].Replace('.', ',')),
                    X_romance = Convert.ToDouble(tmp[7].Replace('.', ',')),
                    X_music = Convert.ToDouble(tmp[8].Replace('.', ',')),
                    X_criticrate = Convert.ToDouble(tmp[9].Replace('.', ',')),
                    X_scary = Convert.ToDouble(tmp[10].Replace('.', ','))
                };
            }
            return movie;
        }
    }
}