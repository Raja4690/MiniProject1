using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiniProject1.Models;
using MiniProject1.ViewModel;

namespace MiniProject1.Repositories
{

    public class OrderRepository
    {

        private readonly MiniProject1Entities2 objminiProjectEntities;

        public OrderRepository()
        {
            objminiProjectEntities = new MiniProject1Entities2();
        }


        public bool AddOrder(OrderViewModel objOrderViewmodel)
        {
            Order objOrder = new Order();
            objOrder.CustomerId = objOrderViewmodel.CustomerId;
            objOrder.FinalTotal = objOrderViewmodel.FinalTotal;
            objOrder.OrderDate = DateTime.Now;
            objOrder.OrderNumber = String.Format("{0:ddmmyyyyhhmmss}",DateTime.Now);
            objOrder.PaymentId = objOrderViewmodel.PaymentId;
            objminiProjectEntities.Orders.Add(objOrder);
            int OrderId = objOrder.OrderId;

            foreach (var Product in objOrderViewmodel.ListOfOrderDetailViewModel)

            {
                OrderDetail objOrderDetail = new OrderDetail();
                objOrderDetail.OrderId =Product.OrderId;
                objOrderDetail.Discount = Product.Discount;
                objOrderDetail.ProductId = Product.ProductId;
                objOrderDetail.TotalAmount = Product.TotalAmount;
                objOrderDetail.ProductPrice = Product.ProductPrice;
                objOrderDetail.Quantity = Product.Quantity;
                objminiProjectEntities.OrderDetails.Add(objOrderDetail);
                objminiProjectEntities.SaveChanges();

                Transaction objtransaction = new Transaction();
                objtransaction.ProductId = Product.ProductId;
                objtransaction.Quantity = Product.Quantity;
                objtransaction.TransactionDate = DateTime.Now;
                objminiProjectEntities.Transactions.Add(objtransaction);
                objminiProjectEntities.SaveChanges();


                
            }
            
            return true;
        }
    }
}