using System;
using CoPoleci.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoPoleci
{
    /// <summary>
    /// Logika interakcji dla klasy Actors.xaml
    /// </summary>
    public partial class Actors : UserControl
    {
        public Actors()
        {
            InitializeComponent();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListViewActors.ItemsSource);
            view.Filter = ItemSearcher;
        }
        private bool ItemSearcher(object item)
        {
            if (String.IsNullOrEmpty(searchingBox.Text))
                return true;
            else
                return ((item as Country).Name.IndexOf(searchingBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void SearchingBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListViewActors.ItemsSource).Refresh();
        }
        private void Actor_Clicked(object sender, RoutedEventArgs e)
        {
            //tu bedzie pojawianie się kontrolki aktora albo w najgorszym wypadku messageboxa ze szczegółami 
        }
    }
}