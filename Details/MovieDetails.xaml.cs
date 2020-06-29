using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CoPoleci.DAL;

namespace CoPoleci
{
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
            LoadInfo();
            LoadIcons();
            ActorListView.ItemsSource = ActorRepo.GetActorsFromMovie(clickedmovie);
            ActorListView.Items.Refresh();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            movieTitle_TextBlock.Text = clickedmovie.Title;
            year_TextBlock.Text = "Rok produkcji: " + clickedmovie.Year.ToString();
            genre_TextBlock.Text = "Gatunek: " + clickedmovie.Genre;
            posterImage.Children.Add(new Image { Height = 500, Width = 190, Source = clickedmovie.Poster, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left });
            directorPhoto.Children.Add(new Image { Height = 200, Width = 75, Source = DirectorRepo.GetDirectorsFromMovie(clickedmovie)[0].Photo, HorizontalAlignment=HorizontalAlignment.Left});
            directorName.Text = DirectorRepo.GetDirectorsFromMovie(clickedmovie)[0].Name;
            companyPhoto.Children.Add(new Image { Height = 200, Width = 75, Source = DirectorRepo.GetDirectorsFromMovie(clickedmovie)[0].Photo, HorizontalAlignment = HorizontalAlignment.Left });
            companyName.Text = DirectorRepo.GetDirectorsFromMovie(clickedmovie)[0].Name;
        }
        private void Actor_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var clickedactor = QueryManager.Actors.Find(i => i.Id == Convert.ToUInt16(btn.Tag));

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new ActorDetails(clickedactor));
        }
        private void LoadIcons() {
           
            Image img = new Image
            {
                Height = 85,
                Width = 85,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bdirectors.png", UriKind.Relative))
            };
            Image img2 = new Image
            {
                Height = 85,
                Width = 85,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bcompanies.png", UriKind.Relative))
              


            };
            Image img3 = new Image
            {
                Height = 85,
                Width = 85,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bactors.png", UriKind.Relative))
            };
            Image img4 = new Image
            {
                Height = 85,
                Width = 85,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bseen.png", UriKind.Relative))
            };
            iconDirector.Children.Add(img);
            iconCompany.Children.Add(img2);
            iconActor.Children.Add(img3);
            iconSeen.Children.Add(img4);
        }

        

        // Powrót do zakładki:
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }

        // Dodawanie filmu do ulubionych:
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
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

        // Usuwanie filmu z ulubionych:
        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
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