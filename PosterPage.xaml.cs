using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class PosterPage : Page
    {
        public PosterPage()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            movieTitle.Text = Ratings.currentItem;
            string nameOfPoster = Ratings.currentItem + ".jpg";
            Image img = new Image
            {
                Height = 400,
                Width = 150,
                Source = new BitmapImage(new Uri($@"\MoviePosters\{nameOfPoster}", UriKind.Relative))
            };
            posterImage.Children.Add(img);
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Result());
        }
    }
}