using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    using CoPoleci.DAL;
    public partial class MovieDetails : UserControl
    {
        private readonly Movie clickedmovie = null;
        public MovieDetails(Movie movie)
        {
            InitializeComponent();
            clickedmovie = movie;
            if (clickedmovie.WasSeen == false)
            {
                ButtonAdd.Visibility = Visibility.Visible;
                ButtonRemove.Visibility = Visibility.Hidden;
            }
            else
            {
                ButtonAdd.Visibility = Visibility.Hidden;
                ButtonRemove.Visibility = Visibility.Visible;
            }
            LoadImages();
        }

        // Załadowanie grafiki będącej plakatem:
        private void LoadImages()
        {
            movieTitle_TextBlock.Text = clickedmovie.Title;
            year_TextBlock.Text = "Rok produkcji: " + clickedmovie.Year.ToString();
            genre_TextBlock.Text = "Gatunek: " + clickedmovie.Genre;
            posterImage.Children.Add(new Image { Height = 500, Width = 190, Source = clickedmovie.Poster, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left });
        }

        // Powrót do strony końcowej:
        private void ButtonWroc_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Clear();
                    (window as MainWindow).GridPrincipal.Children.Add(TabManager.Movies);
                }
            }
        }

        // Dodawanie filmu do ulubionych:
        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (MovieRepo.AddToSeen(clickedmovie) == false)
            {
                MessageBox.Show("Nie udało się dodać filmu do obejrzanych!");
                return;
            }
            clickedmovie.WasSeen = true;
            ButtonAdd.Visibility = Visibility.Hidden;
            ButtonRemove.Visibility = Visibility.Visible;
        }

        private void ButtonUsun_Click(object sender, RoutedEventArgs e)
        {
            if (MovieRepo.RemoveFromSeen(clickedmovie) == false)
            {
                MessageBox.Show("Nie udało się usunąć filmu z obejrzanych!");
                return;
            }
            clickedmovie.WasSeen = false;
            ButtonAdd.Visibility = Visibility.Visible;
            ButtonRemove.Visibility = Visibility.Hidden;
        }
    }
}