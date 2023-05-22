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
            var personal = db.context.Personal.FirstOrDefault(x => x.Personal_Login == LoginTextBox.Text);
           
            if (personal != null)
            {
                if(personal.Personal_Login==LoginTextBox.Text&& personal.Personal_Password == PasswordPasswordBox.Password)
                {
                    this.NavigationService.Navigate(new MainPage());
                }
                else
                {
                    MessageBox.Show("ты какашка!");
                }

            }
            else
            {
                MessageBox.Show("ты какашка!2");
            }
        }
    }
}
