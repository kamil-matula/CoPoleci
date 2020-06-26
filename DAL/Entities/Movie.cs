using MySql.Data.MySqlClient;
using System;
using System.Windows.Media.Imaging;
using System.Collections.Generic;

namespace CoPoleci.DAL
{
    public class Movie
    {
        public byte Id { get; private set; }
        public string Title { get; private set; }
        public BitmapImage Poster { get; private set; }
        public short Year { get; private set; }
        public string Genre { get; private set; }
        public double X_fun { get; private set; }
        public double X_real { get; private set; }
        public double X_age { get; private set; }
        public double X_emo { get; private set; }
        public double X_ambit { get; private set; }
        public double X_action { get; private set; }
        public double X_romance { get; private set; }
        public double X_music { get; private set; }
        public double X_criminal { get; private set; }
        public double X_scary { get; private set; }

        public Movie(List<double> ratings) 
        {
            X_fun = ratings[0];
            X_real = ratings[1];
            X_age = ratings[2];
            X_emo = ratings[3];
            X_ambit = ratings[4];
            X_action = ratings[5];
            X_romance = ratings[6];
            X_music = ratings[7];
            X_criminal = ratings[8];
            X_scary = ratings[9];
        }

        public Movie(MySqlDataReader dataReader)
        {
            Id = (byte)dataReader["id"];
            Title = dataReader["tytuł"].ToString();
            Poster = new BitmapImage(new Uri($@"\MoviePosters\{Title}.jpg", UriKind.Relative));
            Year = (short)dataReader["rok"];
            Genre = dataReader["gatunek"].ToString();
            X_fun = (double)dataReader["zabawność"];
            X_real = (double)dataReader["realizm"];
            X_emo = (double)dataReader["wzruszenie"];
            X_ambit = (double)dataReader["ambitność"];
            X_action = (double)dataReader["akcja"];
            X_romance = (double)dataReader["romantyczność"];
            X_music = (double)dataReader["muzyka"];
            X_criminal = (double)dataReader["kryminalistyka"];
        }

        public override string ToString()
        {
            return $"{Id} {Title} {Year} {Genre}";
        }
    }
}