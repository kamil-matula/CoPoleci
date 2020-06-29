using System;
using CoPoleci.DAL;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class MoviesTab : UserControl
    {
        public MoviesTab()
        {
            InitializeComponent();
            LoadIcon();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListViewMovies.ItemsSource);
            view.Filter = ItemSearcher;
        }

        private bool ItemSearcher(object item)
        {
            if (string.IsNullOrEmpty(searchingBox.Text))
                return true;
            else
                return (item as Movie).Title.IndexOf(searchingBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void SearchingBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListViewMovies.ItemsSource).Refresh();
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

        private void LoadIcon()
        {
            string nameOfImage = "bmovie.png";
            Image img = new Image
            {
                Height = 130,
                Width = 140,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(25, 0, 0, 0),
                Source = new BitmapImage(new Uri($@"\Graphics\Images\{nameOfImage}", UriKind.Relative))
            };

            icon.Children.Add(img);
        }
    }
}