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
using VolgaSpecRemSrroyApp.DB.Entity;
using VolgaSpecRemSrroyApp.Pages;

namespace VolgaSpecRemSrroyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = User.userAunt;
        }

        private void ListServiceClick(object sender, RoutedEventArgs e)
        {
            NavigateFrame.Navigate(new ServiceListPae());

        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            NavigateFrame.Navigate(new RegistratoinPage());

        }

        private void TestConnectionClick(object sender, RoutedEventArgs e)
        {
            NavigateFrame.Navigate(new TestConnectionPage());

        }
    }
}
