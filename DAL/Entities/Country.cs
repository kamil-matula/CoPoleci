using MySql.Data.MySqlClient;
using System;
using System.Windows.Media.Imaging;

namespace CoPoleci.DAL
{
    public class Country
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public int Population { get; private set; }
        public BitmapImage Poster { get; private set; }

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