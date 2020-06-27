using MySql.Data.MySqlClient;
using System.Windows.Media.Imaging;
using System;

namespace CoPoleci.DAL
{
    public class Company
    {
        public string Name { get; private set; }
        public string HeadQuarters { get; private set; }
        public short Founded { get; private set; }
        public BitmapImage Photo { get; private set; }

        public Company(MySqlDataReader dataReader)
        { 
            Name = dataReader["nazwa"].ToString();
            HeadQuarters = dataReader["siedziba"].ToString();
            Founded = (short)dataReader["rok_założenia"];
            Photo = new BitmapImage(new Uri($@"\FilmProductionLogos\{Name}.jpg", UriKind.Relative));
        }

        public override string ToString()
        {
            return $"{Name} {HeadQuarters} {Founded}";
        }
    }
}