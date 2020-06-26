using System;
using CoPoleci.DAL;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class ActorsTab : UserControl
    {
        public ActorsTab()
        {
            InitializeComponent();
            LoadIcon();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListViewActors.ItemsSource);
            view.Filter = ItemSearcher;
        }

        private bool ItemSearcher(object item)
        {
            if (string.IsNullOrEmpty(searchingBox.Text))
                return true;
            else
                return ((item as Country).Name.IndexOf(searchingBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void SearchingBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListViewActors.ItemsSource).Refresh();
        }

        private void Actor_Clicked(object sender, RoutedEventArgs e)
        {
            //tu bedzie pojawianie się kontrolki aktora albo w najgorszym wypadku messageboxa ze szczegółami 
        }
        private void LoadIcon()
        {

            string nameOfImage = "bactors.png";
            Image img = new Image
            {
                Height = 130,
                Width = 140,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(25, 0, 0, 0),
                Source = new BitmapImage(new Uri($@"\Images\{nameOfImage}", UriKind.Relative))
            };

            icon.Children.Add(img);
        }
    }
}