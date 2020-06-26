using MySql.Data.MySqlClient;
using System.Windows.Media.Imaging;
using System;

namespace CoPoleci.DAL
{
    public class Actor
    {
        public ushort Id { get; private set; }
        public string Name { get; private set; }
        public DateTime Born { get; private set; } // NIE WIEM JAK ZROBIĆ, ŻEBY NIE BYŁO GODZINY
        public DateTime Died { get; private set; }
        public BitmapImage Photo { get; private set; }

        public Actor(MySqlDataReader dataReader)
        {
            Id = (ushort)dataReader["id"];
            Name = dataReader["imię_nazwisko"].ToString();
            Born = (DateTime)dataReader["urodzony"];
            try { Died = (DateTime)dataReader["zmarł"]; }  // PROBLEM Z NULLEM
            catch { Died = DateTime.Today; }
            Photo = new BitmapImage(new Uri($@"\MoviePosters\Avatar.jpg", UriKind.Relative));
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Born} {Died}";
        }
    }
}