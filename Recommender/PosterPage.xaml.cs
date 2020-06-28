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
            LoadImages();
        }

        // Załadowanie grafiki będącej plakatem:
        private void LoadImages()
        {
            movieTitle_TextBlock.Text = clickedmovie.Title;
            genre_TextBlock.Text = clickedmovie.Genre;
            year_TextBlock.Text = clickedmovie.Year.ToString();
            posterImage.Children.Add(new Image { Height = 400, Width = 150, Source = clickedmovie.Poster });
        }

        // Powrót do strony końcowej:
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Clear();
                    (window as MainWindow).GridPrincipal.Children.Add(new Result());
                }
            }
        }
    }
}