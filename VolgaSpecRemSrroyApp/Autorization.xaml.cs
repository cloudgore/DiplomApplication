using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
using VolgaSpecRemSrroyApp.DB;
using VolgaSpecRemSrroyApp.DB.Entity;

namespace VolgaSpecRemSrroyApp
{
    /// <summary>
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {

                User user = EFModel.Init().Users.Where(u => u.Login == loginTb.Text && u.Password == passTb.Password).FirstOrDefault();

            if (user != null)
            {
                User.userAunt = user;

                new MainWindow().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка , неверный логин или пароль");
            }
        }
    }
}
