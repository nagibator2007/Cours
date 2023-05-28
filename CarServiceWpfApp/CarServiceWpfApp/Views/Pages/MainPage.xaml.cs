using CarServiceWpfApp.Model;
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

namespace CarServiceWpfApp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Core db=new Core();
        Personal personalGet;
        public MainPage(Personal personal)
        {
          
            personalGet=personal;
            
            InitializeComponent();
            GreetingTextBlock.Text = $"Здарова, заебал {personal.Personal_Login}!";
        }

        //private void OrdersButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.NavigationService.Navigate(new WorkOrdersPage());
        //}

        //private void SettingsButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.NavigationService.Navigate(new SettingsPage());
        //}

        //private void ReportsButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //this.NavigationService.Navigate(new ());
        //}

        //private void WarehouseButton_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
