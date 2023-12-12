using NaityKinoErmoshin.Models;
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
    /// Логика взаимодействия для AddKinoPage.xaml
    /// </summary>
    public partial class AddKinoPage : Page
    {
        Film contextFilm;
        public AddKinoPage(Film film)
        {
            InitializeComponent();
            contextFilm = film;
            DataContext = contextFilm;
        }

        private void BtnSaveKino_Click(object sender, RoutedEventArgs e)
        {
            if (contextFilm.Id == 0)
                App.DB.Film.Add(contextFilm);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
