using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    using CoPoleci.DAL;
    public partial class PosterPage : UserControl
    {
        private readonly Movie clickedmovie = null;
        public PosterPage()
        {
            InitializeComponent();
            clickedmovie = QueryManager.Movies.Find(i => i.Title == Ratings.currentItem);
            LoadInfo();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            movieTitle_TextBlock.Text = clickedmovie.Title;
            year_TextBlock.Text = "Rok produkcji: " + clickedmovie.Year.ToString();
            genre_TextBlock.Text = "Gatunek: " + clickedmovie.Genre;
            posterImage.Children.Add(new Image { Height = 750, Width = 275, Source = clickedmovie.Poster, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left });
        }

        // Powrót do strony końcowej:
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }

        // Przejście do strony ze szczegółami filmu:
        private void ButtonSee_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new MovieDetails(clickedmovie));
        }
    }
}