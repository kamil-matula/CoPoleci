using CoPoleci.DAL;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CoPoleci
{
    public partial class CompaniesTab : UserControl
    {
        public CompaniesTab()
        {
            InitializeComponent();
            LoadIcon();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListViewCompanies.ItemsSource);
            view.Filter = ItemSearcher;
        }

        private bool ItemSearcher(object item)
        {
            if (string.IsNullOrEmpty(searchingBox.Text))
                return true;
            else
                return (item as Company).Name.IndexOf(searchingBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void SearchingBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListViewCompanies.ItemsSource).Refresh();
        }

        private void Company_Clicked(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var clickedcompany = QueryManager.Companies.Find(i => i.Name == btn.Tag.ToString());

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.Add(new CompanyDetails(clickedcompany));
        }

        private void LoadIcon()
        {
            string nameOfImage = "bcompanies.png";
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