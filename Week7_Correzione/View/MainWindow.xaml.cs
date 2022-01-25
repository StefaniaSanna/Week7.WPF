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
using Week7_Correzione.Models;

namespace Week7_Correzione.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IProductRepository productRepository = new ProductRepositoryMock();

        double totale;
        public MainWindow()
        {
            InitializeComponent();
            listProduct.ItemsSource = productRepository.GetAll().Select(p=>p.Name); //così la lista in B sarà una lisy di stringhe
        }

        private void ViewProduct(object sender, RoutedEventArgs e)//questo motido è come onNotificationReceived
        {
            var selectedName = listProduct.SelectedItem;
            if(selectedName != null)
            {
                Product product = productRepository.GetAll().FirstOrDefault(p => p.Name.Equals(selectedName));
                txtDetails.Text = product.ToString();

            }

        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {
            var selectedName = listProduct.SelectedItem;
            if (selectedName != null)
            {
                Product product = productRepository.GetAll().FirstOrDefault(p => p.Name.Equals(selectedName));
                totale += product.Price;
                PriceDetails.Text = totale.ToString();

            }

        }
    }
}
