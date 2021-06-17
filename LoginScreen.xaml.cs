using System.Windows;
using System.Collections.Generic;
using CoPoleci.DAL;

namespace CoPoleci
{
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        #region Metody zdarzeń
        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string nick = textBoxLogin.Text, pwd = textBoxPassword.Password;
            if (AccountCheck(nick, pwd) == false) return;
            DBConnection.Login(nick, pwd);

            MainWindow win = new MainWindow();
            win.Show();
            Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow win = new RegisterWindow();
            win.Show();
            Close();
        }

        // Sprawdzenie czy jest dostęp do bazy danych i czy istnieje użytkownik o podanych danych (nick + hasło):
        private bool AccountCheck(string nickname, string password)
        {
            if (DBConnection.LoginAsRoot("root_config.txt") == false)
            {
                MessageBox.Show("Nie odnaleziono pliku konfiguracyjnego!");
                return false;
            }

            List<User> ExistingUsers = QueryManager.Users; // root pobiera listę użytkowników z bazy
            if (ExistingUsers.Contains(null))
            {
                MessageBox.Show("Brak dostępu do bazy!");
                return false;
            }

            if (ExistingUsers.Count == 0)
            {
                MessageBox.Show("Baza użytkowników jest pusta!");
                return false;
            }

            int user_index = 0;
            while (user_index < ExistingUsers.Count)
            {
                if (ExistingUsers[user_index].UserID == nickname) break;
                user_index++;
            }
            if (user_index == ExistingUsers.Count || UserRepo.HashPassword(password) != ExistingUsers[user_index].Password)
            {
                MessageBox.Show("Nieprawidłowa nazwa użytkownika lub hasło!");
                return false;
            }

            return true;
        }
        #endregion
    }
}
