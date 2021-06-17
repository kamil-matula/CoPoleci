using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CoPoleci.DAL;

namespace CoPoleci
{
    public partial class ActorDetails : UserControl
    {
        private readonly Actor clickedactor = null;
        public ActorDetails(Actor actor)
        {
            InitializeComponent();
            clickedactor = actor;
            LoadInfo();
            LoadIcons();
            MovieListView.ItemsSource = MovieRepo.GetMoviesFromActor (clickedactor);
            MovieListView.Items.Refresh();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            actorName_TextBlock.Text = clickedactor.Name;
            actorBorn_TextBlock.Text = "Data urodzenia: " + clickedactor.Born.ToString();
            try
            {
                actorDied_TextBlock.Text = "Data śmierci:      " + clickedactor.Died.ToString();
            }
            catch { }
            image.Children.Add(new Image { Height = 500, Width = 190, Source = clickedactor.Photo, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left  });
        }

        // Powrót do zakładki:
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }

        // Przejście do filmu:
        private void Movie_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Movie clickedmovie = QueryManager.Movies.Find(i => i.Id == Convert.ToUInt16(btn.Tag));
            _ = QueryManager.SeenMovies; // odświeża właściwości WasSeen, AddToSeenDate i Rate w klasie Movie

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new MovieDetails(clickedmovie));
        }

        private void LoadIcons()
        {
            Image img1 = new Image
            {
                Height = 40,
                Width = 80,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\arrow.png", UriKind.Relative))
            };

            array.Children.Add(img1);
        }
    }
}