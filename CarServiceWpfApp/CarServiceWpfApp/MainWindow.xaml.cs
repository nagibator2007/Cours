using CarServiceWpfApp.Model;
using CarServiceWpfApp.Views.Pages;
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

namespace CarServiceWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core db = new Core();
        int IdPer;
        string roleNamePer;
        string NamePer;
        string surnamePer;

        public MainWindow(int roleId, string role, string name, string surname, string lastname)
        {
            InitializeComponent();

            IdPer = db.context.Personal.Where(x => x.Personal_Login == NamePer).Where(x => x.Personal_Surname == surnamePer).Select(x => x.Personal_Id).First();
            PagesNavigation.Navigate(new MainPage(idPer));

        }



        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new MainPage(idPer));
        }

        private void rdHome_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rdWorkOrders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdStock_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdReports_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rdSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdSettings_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
