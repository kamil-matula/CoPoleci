using CoPoleci.DAL;
using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace CoPoleci
{
    public partial class SeenMoviesTab : UserControl
    {
        public SeenMoviesTab()
        {
            InitializeComponent();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(items.ItemsSource);
            view.Filter = ItemSearcher;
        }
        private bool ItemSearcher(object item)
        {
            if (string.IsNullOrEmpty(searchingBox.Text))
                return true;
            else
                return ((item as Country).Name.IndexOf(searchingBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void SearchingBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(items.ItemsSource).Refresh();
        }
    }
}