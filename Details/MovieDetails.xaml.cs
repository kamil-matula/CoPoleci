using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CoPoleci.DAL;

namespace CoPoleci
{
    public partial class MovieDetails : UserControl
    {
        private readonly Movie clickedmovie = null;
        private Director thismoviesdirector = null;
        private Company thismoviescompany = null;

        public MovieDetails(Movie movie)
        {
            InitializeComponent();
            
            clickedmovie = movie;
            if (clickedmovie.WasSeen == false)
            {
                ButtonAdd.Visibility = Visibility.Visible;
                ButtonRemove.Visibility = Visibility.Hidden;
                ButtonConfirm.Visibility = Visibility.Hidden;
                ButtonEdit.Visibility = Visibility.Hidden;
                Rate_TextBox.Visibility = Visibility.Hidden;
                Rate_TextBlock.Visibility = Visibility.Hidden;
            }
            else
            {
                ButtonAdd.Visibility = Visibility.Hidden;
                ButtonRemove.Visibility = Visibility.Visible;
                ButtonConfirm.Visibility = Visibility.Hidden;
                ButtonEdit.Visibility = Visibility.Visible;
                Rate_TextBox.Visibility = Visibility.Hidden;
                Rate_TextBlock.Visibility = Visibility.Visible;
            }

            LoadInfo();
            LoadIcons();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            movieTitle_TextBlock.Text = clickedmovie.Title;
            year_TextBlock.Text = "Rok produkcji: " + clickedmovie.Year.ToString();
            genre_TextBlock.Text = "Gatunek: " + clickedmovie.Genre;
            posterImage.Children.Add(new Image { Height = 510, Width = 194, Source = clickedmovie.Poster, 
                VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left });

            thismoviesdirector = DirectorRepo.GetDirectorsFromMovie(clickedmovie)[0]; // w tej chwili jest tylko jeden reżyser na film
            directorPhoto.Children.Add(new Image { Height = 120, Width = 80, Source = thismoviesdirector.Photo, 
                HorizontalAlignment=HorizontalAlignment.Center, VerticalAlignment=VerticalAlignment.Center});
            directorName.Text = thismoviesdirector.Name;

            thismoviescompany = CompanyRepo.GetCompanyFromMovie(clickedmovie);
            companyPhoto.Children.Add(new Image { Height=90, Width = 120, Source = thismoviescompany.Photo, 
                HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Bottom});
            companyName.Text = thismoviescompany.Name;

            ActorListView.ItemsSource = ActorRepo.GetActorsFromMovie(clickedmovie);
            ActorListView.Items.Refresh();

            if (string.IsNullOrEmpty(clickedmovie.Rate)) Rate_TextBlock.Text = "Komentarz nie został dodany.";
            else Rate_TextBlock.Text = clickedmovie.Rate;
        }

        // Przejście do strony aktora:
        private void Actor_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Actor clickedactor = QueryManager.Actors.Find(i => i.Id == Convert.ToUInt16(btn.Tag));

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new ActorDetails(clickedactor));
        }

        // Przejście do strony reżysera:
        private void Director_Clicked(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new DirectorDetails(thismoviesdirector));
        }

        // Przejście do strony wytwórni:
        private void Company_Clicked(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new CompanyDetails(thismoviescompany));
        }


        private void LoadIcons() {
           
            Image img = new Image
            {
                Height = 35,
                Width = 35,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bdirectors.png", UriKind.Relative))
            };

            Image img2 = new Image
            {
                Height = 35,
                Width = 35,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bcompanies.png", UriKind.Relative))
            };

            Image img3 = new Image
            {
                Height = 105,
                Width = 105,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bactors.png", UriKind.Relative))
            };

            Image img4 = new Image
            {
                Height = 65,
                Width = 65,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bseen.png", UriKind.Relative))
            };
            Image img5 = new Image
            {
                Height = 65,
                Width = 65,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\bseenyes.png", UriKind.Relative))
            };
            Image img6 = new Image
            {
                Height = 40,
                Width = 80,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(1, 1, 1, 1),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\arrow.png", UriKind.Relative))
            };

            iconDirector.Children.Add(img);
            iconCompany.Children.Add(img2);
            iconActor.Children.Add(img3);
            notseenIcon.Children.Add(img4);
            seenIcon.Children.Add(img5);
            array.Children.Add(img6);
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
            ButtonEdit.Visibility = Visibility.Visible;
            ButtonConfirm.Visibility = Visibility.Hidden;
            Rate_TextBlock.Visibility = Visibility.Visible;
            Rate_TextBox.Visibility = Visibility.Hidden;
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
            clickedmovie.Rate = "";
            clickedmovie.AddToSeenDate = "";
            Rate_TextBlock.Text = "Komentarz nie został dodany.";

            ButtonAdd.Visibility = Visibility.Visible;
            ButtonRemove.Visibility = Visibility.Hidden;
            ButtonEdit.Visibility = Visibility.Hidden;
            ButtonConfirm.Visibility = Visibility.Hidden;
            Rate_TextBlock.Visibility = Visibility.Hidden;
            Rate_TextBox.Visibility = Visibility.Hidden;
        }

        // Edytowanie komentarza:
        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            Rate_TextBlock.Visibility = Visibility.Hidden;
            Rate_TextBox.Visibility = Visibility.Visible;
            ButtonEdit.Visibility = Visibility.Hidden;
            ButtonConfirm.Visibility = Visibility.Visible;
            Rate_TextBox.Text = clickedmovie.Rate;
        }

        // Zatwierdzanie edycji komentarza:
        private void ButtonConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (MovieRepo.UpdateRate(clickedmovie, Rate_TextBox.Text) == false)
            {
                MessageBox.Show("Nie udało się zmienić komentarza!");
                return;
            }
            _ = QueryManager.SeenMovies; // odświeża właściwości WasSeen, AddToSeenDate i Rate w klasie Movie

            Rate_TextBlock.Text = Rate_TextBox.Text;
            Rate_TextBlock.Visibility = Visibility.Visible;
            Rate_TextBox.Visibility = Visibility.Hidden;
            ButtonEdit.Visibility = Visibility.Visible;
            ButtonConfirm.Visibility = Visibility.Hidden;
        }
    }
}