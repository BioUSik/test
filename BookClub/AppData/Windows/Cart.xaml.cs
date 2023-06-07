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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Page
    {
        public Cart()
        {
            InitializeComponent();
            BookInCart.ItemsSource = AppData.Entities.Cart.bookInCart;
        }

        private void RefreshCart()
        {
            AppData.ProgrammFrame.programmFrame.Navigate(new AppData.Windows.Cart());
        }

        private void AddCountBtn_Click(object sender, RoutedEventArgs e)
        {
            var cartItem = (sender as Button).DataContext as AppData.Entities.Books;
            int index = AppData.Entities.Cart.bookInCart.FindIndex(b => b.BookId == cartItem.BookId);
            AppData.Entities.Cart.bookInCart[index].CountBookInOrder++;
            RefreshCart();
        }

        private void MinusCountBtn_Click(object sender, RoutedEventArgs e)
        {
            var cartItem = (sender as Button).DataContext as AppData.Entities.Books;
            int index = AppData.Entities.Cart.bookInCart.FindIndex(b => b.BookId == cartItem.BookId);
            if (AppData.Entities.Cart.bookInCart[index].CountBookInOrder == 1)
            {
                if (MessageBox.Show("Вы хотите удалить товар из корзины?", "Возник вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    AppData.Entities.Cart.bookInCart.RemoveAt(index);
                    MessageBox.Show("Вы удалили товар из корзины");
                }
                else
                {
                    MessageBox.Show("Товар не удален из корзины");
                }
            } else
            {
                AppData.Entities.Cart.bookInCart[index].CountBookInOrder--;
            }
            RefreshCart();
        }

        private void DelInCart_Click(object sender, RoutedEventArgs e)
        {
            var cartItem = (sender as MenuItem).DataContext as AppData.Entities.Books;
            Console.WriteLine(cartItem.BookName);
            //int index = AppData.Entities.Cart.bookInCart.FindIndex(b => b.BookId == cartItem.BookId);
            //if (MessageBox.Show("Вы хотите удалить товар из корзины?", "Возник вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    AppData.Entities.Cart.bookInCart.RemoveAt(index);
            //    RefreshCart();
            //    MessageBox.Show("Вы удалили товар из корзины");
            //}
            //else
            //{
            //   MessageBox.Show("Товар не удален из корзины");
            //}
        }
    }
}
