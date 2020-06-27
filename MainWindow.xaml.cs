using CoPoleci.Tabs;
using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridPrincipal.Children.Add(new Home());
        }


        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new Home());
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            switch (index)
            {

                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(TabManager.SeenMovies);
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(TabManager.Movies);
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(TabManager.Actors);
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(TabManager.Directors);
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(TabManager.Companies);
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(TabManager.Ranking);
                    break;
                case 6:
                    Questions.Number = 0;
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Start());
                    break;
                default:
                    break;
            }
        }

    }
}