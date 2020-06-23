using MySql.Data.MySqlClient;
using System;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BitmapImage Poster { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public double X_fun { get; set; }
        public double X_real { get; set; }
        public double X_age { get; set; }
        public double X_emo { get; set; }
        public double X_ambit { get; set; }
        public double X_action { get; set; }
        public double X_romance { get; set; }
        public double X_music { get; set; }
        public double X_criticrate { get; set; }
        public double X_scary { get; set; }

        public Movie() { }

        public Movie(MySqlDataReader dataReader)
        {
            Id = (int)dataReader["id"];
            Title = dataReader["title"].ToString();
            Poster = new BitmapImage(new Uri($@"\MoviePosters\{Title}.jpg", UriKind.Relative));
            Year = (int)dataReader["year"];
            Genre = dataReader["genre"].ToString();
            X_fun = (double)dataReader["X_fun"];
            X_real = (double)dataReader["X_real"];
            X_age = (double)dataReader["X_age"];
            X_emo = (double)dataReader["X_emo"];
            X_ambit = (double)dataReader["X_ambit"];
            X_action = (double)dataReader["X_action"];
            X_romance = (double)dataReader["X_romance"];
            X_music = (double)dataReader["X_music"];
            X_criticrate = (double)dataReader["X_criticrate"];
            X_scary = (double)dataReader["X_scary"];
        }

        public override string ToString()
        {
            return $"{Id} {Title} {Year} {Genre}";
        }
    }
}