using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.AppData.Entities
{
    public static class Cart
    {
        static public List<AppData.Entities.Books> bookInCart { get; set; }
        static public decimal TotalPrice { get; set; }
    }
}
