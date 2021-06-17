using CoPoleci.DAL;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class DirectorsTab : UserControl
    {
        public DirectorsTab()
        {
            InitializeComponent();
            LoadIcon();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListViewDirectors.ItemsSource);
            view.Filter = ItemSearcher;
        }

        private bool ItemSearcher(object item)
        {
            if (string.IsNullOrEmpty(searchingBox.Text))
                return true;
            else
                return (item as Director).Name.IndexOf(searchingBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void SearchingBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListViewDirectors.ItemsSource).Refresh();
        }

        private void Director_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Director clickeddirector = QueryManager.Directors.Find(i => i.Id == Convert.ToUInt16(btn.Tag));

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new DirectorDetails(clickeddirector));
        }

        private void LoadIcon()
        {
            string nameOfImage = "bdirectors.png";
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
