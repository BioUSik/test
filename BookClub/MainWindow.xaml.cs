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

namespace BookClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectToDB.connectToDB = new BookClubEntities();
            AppData.ProgrammFrame.programmFrame = MainProgrammFrm;
            AppData.ProgrammFrame.programmFrame.Navigate(new AppData.Windows.ProductList());
            var books = AppData.Entities.ConnectToDB.connectToDB.Books.ToList();
            books[0].CountBookInOrder = 1;
            books[1].CountBookInOrder = 2;
            AppData.Entities.Cart.bookInCart = new List<AppData.Entities.Books>();
            AppData.Entities.Cart.bookInCart.Add(books[0]);
            //AppData.Entities.Cart.bookInCart.Add(books[0]);
            //AppData.Entities.Cart.bookInCart.Add(testBook);
        }

        private void GoForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.ProgrammFrame.GoForward();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.ProgrammFrame.GoBack();
        }

        private void CartBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.ProgrammFrame.programmFrame.Navigate(new AppData.Windows.Cart());
        }

        private void BookListBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.ProgrammFrame.programmFrame.Navigate(new AppData.Windows.ProductList());
        }
    }
}
