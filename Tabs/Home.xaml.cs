using System;
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

namespace CoPoleci.Tabs
{
    /// <summary>
    /// Logika interakcji dla klasy Home.xaml
    /// </summary>
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
                Source = new BitmapImage(new Uri($@"\FunFacts\{nameOfImage}", UriKind.Relative))
            };
            funfact.Children.Add(img);
        }
    }
}
