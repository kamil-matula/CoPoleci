using CoPoleci.DAL;
using System.Collections.Generic;
using System.Windows;

namespace CoPoleci
{
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
            string nick = textBoxLogin.Text, pwd = textBoxPassword.Password;
            if (AccountCheck(nick, pwd) == false) return;
            if (UserRepo.AddUser(nick, pwd) == false)
            {
                MessageBox.Show("Nie udało się utworzyć użytkownika.");
                return;
            }
            LoginScreen win = new LoginScreen();
            win.Show();
            Close();
        }

        private bool AccountCheck(string nickname, string pwd)
        {
            if (DBConnection.LoginAsRoot("root_config.txt") == false)
            {
                MessageBox.Show("Brak dostępu do bazy danych!");
                return false;
            }

            List<User> ExistingUsers = QueryManager.Users; // root pobiera listę użytkowników z bazy
            int user_index = 0;
            while (user_index < ExistingUsers.Count)
            {
                if (ExistingUsers[user_index].UserID == nickname)
                {
                    MessageBox.Show("Istnieje już użytkownik o takiej nazwie.");
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