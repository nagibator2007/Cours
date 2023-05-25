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
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthPage());
        }

        //private void MainFrameNavigated(object sender, NavigationEventArgs e)
        //{
        //    var currentPage = e.Content;

        //    if (MainFrame.CanGoBack && !(currentPage is MainPage))
        //    {
        //        BackButton.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        BackButton.Visibility = Visibility.Hidden;
        //    }
        //}


        /// <summary>
        /// Кнопка назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
