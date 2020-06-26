using CoPoleci.Tabs;
using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    public partial class MainWindow : Window
    {
        private readonly TabManager tm;
        public MainWindow()
        {
            InitializeComponent();
            tm = new TabManager();
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
                    GridPrincipal.Children.Add(tm.SeenMovies);
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(tm.Movies);
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(tm.Actors);
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(tm.Directors);
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(tm.Companies);
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(tm.Ranking);
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