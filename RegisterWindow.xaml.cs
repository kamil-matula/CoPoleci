using CoPoleci.DAL;
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
using System.Windows.Shapes;

namespace CoPoleci
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen win = new LoginScreen();
            win.Show();
            Close();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
          /*  string nick = textBoxLogin.Text, pwd = textBoxPassword.Password;
            if (AccountCheck(nick, pwd) == false)
                return;
            User newUser = new User(nick, pwd);
            UserRepo.AddUser(newUser);
            LoginScreen win = new LoginScreen();
            win.Show();
            Close();*/
        }
        private bool AccountCheck(string nickname, string pwd)
        {
            List<User> ExistingUsers = QueryManager.Users; // root pobiera listę użytkowników z bazy
            if (ExistingUsers.Count == 0)
            {
                MessageBox.Show("Brak dostępu do bazy użytkowników!");
                return false;
            }

            int user_index = 0;
            while (user_index < ExistingUsers.Count)
            {
                if (ExistingUsers[user_index].UserID == nickname)
                {
                    MessageBox.Show("Istnieje już użytkownik o takiej nazwie");
                    return false;
                }
                user_index++;
            }
            if (pwd.Length == 0 || nickname.Length== 0)
            {
                MessageBox.Show("Uzupełnij puste pola!");
                return false;
            }
            return true;
        }

    }
}