//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookClub.AppData.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class OrderToBooks
    {
        public int OrderToBookId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int CountBookInOrder { get; set; }

        public virtual Books Books { get; set; }
        public virtual Orders Orders { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
