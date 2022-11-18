using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProject1.ViewModel
{
    public class CustomerViewModel
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public int PhoneNumber { get; set; }
        public decimal TotalOrderAmount { get; set; }

    }
}