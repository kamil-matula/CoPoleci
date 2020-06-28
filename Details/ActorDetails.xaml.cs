using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    using CoPoleci.DAL;
    public partial class ActorDetails : UserControl
    {
        private readonly Actor clickedactor = null;
        public ActorDetails(Actor actor)
        {
            InitializeComponent();
            clickedactor = actor;
            LoadInfo();
        }

        // Załadowanie informacji:
        private void LoadInfo()
        {
            actorName_TextBlock.Text = clickedactor.Name;
            actorBorn_TextBlock.Text = "Data urodzenia: " + clickedactor.Born.ToString();
            try
            {
                actorDied_TextBlock.Text = ("Data śmierci:      " + clickedactor.Died.ToString());
            }
            catch { }
            image.Children.Add(new Image { Height = 500, Width = 190, Source = clickedactor.Photo, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Left  });
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