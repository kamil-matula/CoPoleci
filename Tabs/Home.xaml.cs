using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoPoleci.Tabs
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            LoadFunFacts();
        }

        private void LoadFunFacts()
        {
            Random r = new Random();
            int randomint = r.Next(0, 2);
            string nameOfImage = "fact" + randomint.ToString() + ".png";
            Image img = new Image
            {
                Height = 550,
                Width = 550,
                Source = new BitmapImage(new Uri($@"\Graphics\FunFacts\{nameOfImage}", UriKind.Relative))
            };
            funfact.Children.Add(img);
        }
    }
}