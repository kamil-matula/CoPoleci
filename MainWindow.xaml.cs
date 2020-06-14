using System.Windows;

namespace CoPoleci
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new Start());
        }
    }
}