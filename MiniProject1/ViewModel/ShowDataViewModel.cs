using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiniProject1.Models;

namespace MiniProject1.ViewModel
{
    public class ShowDataViewModel
    {
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
     
    }
}