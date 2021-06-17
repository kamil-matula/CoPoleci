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
        public bool WasSeen { get; set; } = false;
        public string AddToSeenDate { get; set; }
        public string Rate { get; set; }

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
            Poster = new BitmapImage(new Uri($@"\Graphics\MoviePosters\{Title}.jpg", UriKind.Relative));
            Year = (short)dataReader["rok"];
            Genre = dataReader["gatunek"].ToString();
            X_fun = (double)dataReader["zabawność"];
            X_real = (double)dataReader["realizm"];
            X_age = AgeConverter(Year);
            X_emo = (double)dataReader["wzruszenie"];
            X_ambit = (double)dataReader["ambitność"];
            X_action = (double)dataReader["akcja"];
            X_romance = (double)dataReader["romantyczność"];
            X_music = (double)dataReader["muzyka"];
            X_criminal = (double)dataReader["kryminalistyka"];
            X_scary = (double)dataReader["strach"];
        }

        private double AgeConverter(short year)
        {
            double yearValue;

            if (year <= 1950)
                yearValue = 0.0;
            else if (year <= 1960)
                yearValue = 0.1;
            else if (year <= 1970)
                yearValue = 0.2;
            else if (year <= 1980)
                yearValue = 0.3;
            else if (year <= 1990)
                yearValue = 0.4;
            else if (year <= 1999)
                yearValue = 0.5;
            else if (year <= 2005)
                yearValue = 0.6;
            else if (year <= 2008)
                yearValue = 0.7;
            else if (year <= 2012)
                yearValue = 0.8;
            else if (year <= 2017)
                yearValue = 0.9;
            else
                yearValue = 1.0;

            return yearValue;
        }
    }
}
