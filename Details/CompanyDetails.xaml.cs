using System.Windows;
using System.Windows.Controls;

namespace CoPoleci
{
    using CoPoleci.DAL;
    public partial class CompanyDetails : UserControl
    {
        private Company clickedcompany = null;
        public CompanyDetails(Company company)
        {
            InitializeComponent();
            clickedcompany = company;
            LoadImages();
        }

        // Załadowanie grafiki będącej plakatem:
        private void LoadImages()
        {
            companyName_TextBlock.Text = clickedcompany.Name;
            companyHeadQuarter_TextBlock.Text = ("Siedziba: " + clickedcompany.HeadQuarters.ToString());
            companyFounded_TextBlock.Text = ("Data założenia: " + clickedcompany.Founded.ToString());          
            image.Children.Add(new Image { Height = 500, Width = 190, Source = clickedcompany.Photo, VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Left });
        }

        // Powrót do strony końcowej:
        private void ButtonWroc_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipal.Children.Clear();
                    (window as MainWindow).GridPrincipal.Children.Add(TabManager.Companies);
                }
            }
        }

      
    }
}