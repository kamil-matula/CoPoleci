using MySql.Data.MySqlClient;
using System;
using System.Windows.Media.Imaging;

namespace CoPoleci.DAL
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public BitmapImage Poster { get; set; }

        public Country(MySqlDataReader dataReader)
        {
            Code = dataReader["code"].ToString();
            Name = dataReader["name"].ToString();
            Population = (int)dataReader["population"];
            Poster = new BitmapImage(new Uri($@"\MoviePosters\Avatar.jpg", UriKind.Relative));

        }

        public override string ToString()
        {
            return $"{Name} {Code} {Population}";
        }
    }
}