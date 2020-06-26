using System.Windows.Controls;
using System.Windows.Data;

namespace CoPoleci
{
    public partial class MovieRankings : UserControl
    {
        public MovieRankings()
        {
            InitializeComponent();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(items.ItemsSource);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}