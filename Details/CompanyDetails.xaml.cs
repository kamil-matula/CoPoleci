using System;
using System.Windows;
using System.Windows.Controls;
using CoPoleci.DAL;

namespace CoPoleci
{
    public partial class CompanyDetails : UserControl
    {
        private readonly Company clickedcompany = null;
        public CompanyDetails(Company company)
        {
            InitializeComponent();
            clickedcompany = company;
            LoadInfo();
            MovieListView.ItemsSource = MovieRepo.GetMoviesFromCompany(clickedcompany);
            MovieListView.Items.Refresh();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            companyName_TextBlock.Text = clickedcompany.Name;
            companyHeadQuarter_TextBlock.Text = "Siedziba: " + clickedcompany.HeadQuarters.ToString();
            companyFounded_TextBlock.Text = "Data założenia: " + clickedcompany.Founded.ToString();          
            image.Children.Add(new Image { Height = 500, Width = 190, Source = clickedcompany.Photo, VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Left });
        }

        // Powrót do zakładki:
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }

        private void Movie_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var clickedmovie = QueryManager.Movies.Find(i => i.Id == Convert.ToUInt16(btn.Tag));
            _ = QueryManager.SeenMovies; // odświeża właściwości WasSeen, AddToSeenDate i Rate w klasie Movie

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new MovieDetails(clickedmovie));
        }
    }
}