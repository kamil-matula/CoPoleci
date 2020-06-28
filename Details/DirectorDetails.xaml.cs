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
            LoadImages();
        }

        // Załadowanie grafiki będącej plakatem:
        private void LoadImages()
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

        // Powrót do strony końcowej:
        private void ButtonWroc_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Clear();
                    (window as MainWindow).GridPrincipal.Children.Add(TabManager.Directors);
                }
            }
        }

       
    }
}