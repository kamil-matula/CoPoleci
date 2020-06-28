using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    using DAL;
    using DAL.Repositories;

    public partial class Result : UserControl
    {
        public Result()
        {
            Movie idealmovie = new Movie(Ratings.RatingsList);
            InitializeComponent();
            string wyniki = "";
            var movies = MovieRepo.GetAllMovies().ToArray();

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

        // Załadowanie grafiki na stronie końcowej:
        private void LoadImages()
        {
            Image img = new Image
            {
                Height = 100,
                Width = 100,
                Source = new BitmapImage(new Uri(@"\Graphics\Images\popcorn.png", UriKind.Relative))
            };
            popcornImage.Children.Add(img);

            Image img2 = new Image
            {
                Height = 110,
                Width = 110,
                Source = new BitmapImage(new Uri(@"\Graphics\Images\filmImage2.png", UriKind.Relative))
            };
            filmImage.Children.Add(img2);
        }

        // Przejście do strony plakatu wybranego filmu:
        private void listaFilmow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ratings.currentItem = (listaFilmow.SelectedItem.ToString()).Substring(3);
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Clear();
                    (window as MainWindow).GridPrincipal.Children.Add(new PosterPage());
                }
            }
        }
    }
}