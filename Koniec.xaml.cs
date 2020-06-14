using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class Koniec : Page
    {
        public Koniec()
        {
            Movie idealmovie = new Movie
            {
                X_fun = Ratings.RatingsList[0],
                X_real = Ratings.RatingsList[1],
                X_age = Ratings.RatingsList[2],
                X_emo = Ratings.RatingsList[3],
                X_ambit = Ratings.RatingsList[4],
                X_action = Ratings.RatingsList[5],
                X_romance = Ratings.RatingsList[6],
                X_music = Ratings.RatingsList[7],
                X_criticrate = Ratings.RatingsList[8],
                X_scary = Ratings.RatingsList[9]
            };

            InitializeComponent();
            string wyniki = "";
            var movies = DataPrep.Upload("bazafilmy.csv");

            KNN knn = new KNN(5, movies, idealmovie);
            var decyzja = knn.MakeDecision();

            int i = 1;

            foreach (var film in decyzja)
            {
                wyniki += film;
                wyniki += "  |  ";

                listaFilmow.Items.Add(i.ToString() + ". " + film);
                i++;
            }

            LoadImages();
        }

        private void LoadImages()
        {
            Image img = new Image
            {
                Height = 100,
                Width = 100,
                Source = new BitmapImage(new Uri(@"\Images\popcorn.png", UriKind.Relative))
            };
            popcornImage.Children.Add(img);

            Image img2 = new Image
            {
                Height = 110,
                Width = 110,
                Source = new BitmapImage(new Uri(@"\Images\filmImage2.png", UriKind.Relative))
            };
            filmImage.Children.Add(img2);
        }

        private void listaFilmow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ratings.currentItem = (listaFilmow.SelectedItem.ToString()).Substring(3);
            this.NavigationService.Navigate(new PosterPage());
        }
    }
}