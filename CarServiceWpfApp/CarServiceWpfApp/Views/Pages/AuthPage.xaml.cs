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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarServiceWpfApp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        Core db = new Core();

        public AuthPage()
        {
            InitializeComponent();
          
        }



        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
           if(db.context.Personal.Where(x=>x.Personal_Login==LoginTextBox.Text&& x.Personal_Password==PasswordPasswordBox.Password).FirstOrDefault()!=null) {

                Personal personal =db.context.Personal.First(x=>x.Personal_Login==LoginTextBox.Text);

                this.NavigationService.Navigate(new MainPage(personal));
            }
            else
            {
                MessageBox.Show("Проверьте правильность введёных значений.");
            }
        }
    }
}
