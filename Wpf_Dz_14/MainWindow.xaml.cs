using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_Dz_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 70,
                ProdImage = "Data/Apple.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Мандарины",
                ProdPrice = 120,
                ProdImage = "Data/Mandarin.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Тыква",
                ProdPrice = 260,
                ProdImage = "Data/Pumpkin.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Микроволновка",
                ProdPrice = 7000,
                ProdImage = "Data/Microwave.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Плита",
                ProdPrice = 3500,
                ProdImage = "Data/Plate.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Умные часы",
                ProdPrice = 35000,
                ProdImage = "Data/Smart_watch.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
