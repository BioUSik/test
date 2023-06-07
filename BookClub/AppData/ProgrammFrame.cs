using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookClub.AppData
{
    internal class ProgrammFrame
    {
        public static Frame programmFrame;

        public static void GoBack()
        {
            if (programmFrame.CanGoBack)
            {
                programmFrame.GoBack();
            }
            else
            {
                MessageBox.Show("Нет предыдущих страниц");
            }
        }

        public static void GoForward()
        {
            if (programmFrame.CanGoForward)
            {
                programmFrame.GoForward();
            }
            else
            {
                MessageBox.Show("Нет следующих страниц");
            }
        }
    }
}
