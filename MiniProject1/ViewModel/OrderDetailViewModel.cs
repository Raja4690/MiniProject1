using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject1.ViewModel
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public Decimal ProductPrice { get; set; }

        public Decimal Discount { get; set; }

        public Decimal TotalAmount { get; set; }
        public Decimal Quantity { get; set; }

        

    }
}