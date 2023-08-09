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
using VolgaSpecRemSrroyApp.DB;
using VolgaSpecRemSrroyApp.DB.Entity;

namespace VolgaSpecRemSrroyApp.Pages
{
    /// <summary>
    /// Interaction logic for ServiceListPae.xaml
    /// </summary>
    public partial class ServiceListPae : Page
    {
        public ServiceListPae()
        {
            InitializeComponent();
            DataContext = User.userAunt;
            List<Category> categories = EFModel.Init().Categories.ToList();
            categories.Insert(0, new Category { Name = "Все категории" });
            CbSort.ItemsSource = categories;
            CbSort.SelectedIndex = 0;
        }
        private  void UpdateData()
        {
            LVService.ItemsSource = null;
            IEnumerable<Service> services = EFModel.Init().Services.Where(u => u.NameService.Contains(TbSearch.Text));
            if (Dispatcher.Invoke(() => CbSort.SelectedIndex > 0))
                services = services.Where(u => u.CategoryID == (CbSort.SelectedItem as Category).ID);
            switch (CbSort.SelectedIndex)
            {
                case 0:
                    services = services.OrderBy(u => u.Cost);
                    break;
                case 1:
                    services = services.OrderByDescending(u => u.Cost);
                    break;
            }
       
            LVService.ItemsSource = services.ToList();
        }

        private void CbSortClick(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void OrderClick(object sender, RoutedEventArgs e)
        {
            Service service = (sender as Button).DataContext as Service;
            NavigationService.Navigate(new ServiceInfo(service));
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeTextClick(object sender, TextChangedEventArgs e)
        {
            UpdateData();

        }
    }
}
