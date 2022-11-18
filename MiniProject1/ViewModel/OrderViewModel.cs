using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject1.ViewModel
{
    public class OrderViewModel
    {
         public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public Decimal FinalTotal { get; set; }
        public IEnumerable<OrderDetailViewModel>ListOfOrderDetailViewModel { get; set; }



    }
}