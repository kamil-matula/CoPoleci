using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class PosterPage : UserControl
    {
        public PosterPage()
        {
            InitializeComponent();
            LoadImages();
        }

        // Załadowanie grafiki będącej plakatem:
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