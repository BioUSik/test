using BookClub.AppData.Entities;
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

namespace BookClub.AppData.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Page
    {

        public ProductList()
        {
            InitializeComponent();
            var bookList = AppData.Entities.ConnectToDB.connectToDB.Books.ToList();

            foreach (var book in bookList)
            {
                book.BookTotalPrice = book.BookPrice - ((book.BookPrice / 100) * book.BookDiscount);
            }

            BookList.ItemsSource = bookList;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DataTemplate_Opened(object sender, RoutedEventArgs e)
        {

        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
