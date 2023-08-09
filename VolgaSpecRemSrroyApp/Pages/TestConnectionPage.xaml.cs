using MySql.Data.MySqlClient;
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

namespace VolgaSpecRemSrroyApp.Pages
{
    /// <summary>
    /// Interaction logic for TestConnectionPage.xaml
    /// </summary>
    public partial class TestConnectionPage : Page
    {
        public TestConnectionPage()
        {
            InitializeComponent();
            DBTb.Text = Properties.Settings.Default.DB;
            HostTb.Text = Properties.Settings.Default.Host;
            PassTb.Text = Properties.Settings.Default.pass;
            UserNameTb.Text = Properties.Settings.Default.UserName;
            PortTb.Text = Properties.Settings.Default.port;
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.DB = DBTb.Text;
            Properties.Settings.Default.Host = HostTb.Text;
            Properties.Settings.Default.pass = PassTb.Text;
            Properties.Settings.Default.UserName = UserNameTb.Text;
            Properties.Settings.Default.port = PortTb.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Успешно");
        }

        private void CheackDBSettingsClick(object sender, RoutedEventArgs e)
        {
            string Connectio = $"server= {HostTb.Text} ;user=" + UserNameTb.Text +
       ";" + "database=" + DBTb.Text + ";" + "password=" + PassTb.Text + ";charset=utf8;";
            MySqlConnection MyConnection = new MySqlConnection(Connectio);
            try
            {
                MyConnection.Open();
                if (MyConnection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Успешно");
                }
            }
            catch (MySqlException exp)
            {
                MessageBox.Show
                    (exp.Message);
            }
        }
    }
}
