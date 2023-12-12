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

namespace NaityKinoErmoshin.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == TBPassword.Text);
            if(user == null)
            {
                MessageBox.Show("Не правильный логин или пароль");
                return;
            }
            else
            {
                MessageBox.Show("Вы успешно авторизировались");
                NavigationService.Navigate(new MenuPage());
                
            }
        }

        private void BtnAuth_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
