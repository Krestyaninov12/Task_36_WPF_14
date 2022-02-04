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

namespace Task_36_WPF_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Рубашка",
                Price = 3000,                
                Image = "/Image/1.jpg",
                Category = Category.Одежда
            });
            products.Add(new Product()
            {
                NameProduct = "Галстук",
                Price = 900,
                Image = "/Image/2.jpg",
                Category = Category.Одежда
            });
            products.Add(new Product()
            {
                NameProduct = "Телефон",
                Price = 1200,
                Image = "/Image/3.jpg",
                Category = Category.Техника
            });
            products.Add(new Product()
            {
                NameProduct = "Принтер",
                Price = 3500,
                Image = "/image/4.jpg",
                Category = Category.Техника
            });
            IstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                NameProduct = "Автомобиль",
                Price = 3200000,
                Image = "/Image/Avto.jpg",
                Category = Category.Транспорт
            });
        }
    }
}
