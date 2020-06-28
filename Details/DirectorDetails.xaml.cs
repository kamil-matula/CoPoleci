using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    using CoPoleci.DAL;
    public partial class DirectorDetails : UserControl
    {
        private readonly Director clickeddirector = null;
        public DirectorDetails(Director director)
        {
            InitializeComponent();
            clickeddirector = director;
            LoadInfo();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            directorName_TextBlock.Text = clickeddirector.Name;
            directorBorn_TextBlock.Text = "Data urodzenia: " + clickeddirector.Born.ToString();
            try
            {

                directorDied_TextBlock.Text = "Data śmierci:      " + clickeddirector.Died.ToString();
            }
            catch { }
            image.Children.Add(new Image { Height = 500, Width = 190, Source = clickeddirector.Photo, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left });
        }

        // Powrót do zakładki:
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MainWindow))
                    (window as MainWindow).GridPrincipal.Children.RemoveAt((window as MainWindow).GridPrincipal.Children.Count - 1);
        }
    }
}