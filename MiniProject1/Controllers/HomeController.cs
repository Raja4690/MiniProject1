using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject1.Models;
using MiniProject1.Repositories;
using MiniProject1.ViewModel;


namespace MiniProject1.Controllers
{
    public class HomeController : Controller
    { 
          
        private readonly MiniProject1Entities2 miniProjectEntities;
        private readonly MiniProject1Entities2 db = new MiniProject1Entities2();
        public HomeController()
        {
            miniProjectEntities = new MiniProject1Entities2();
        }
       
        public ActionResult Cart()
        {
            var tables = new ShowDataViewModel
            {
               OrderDetails  = db.OrderDetails.ToList(),
                Transactions = db.Transactions.ToList(),
                
            };
            return View(tables);
        }
        


        public ActionResult Index()
        {
            var objCustomerRepository = new CustomerRepository();
            var objProductRepository = new ProductRepository();
            var objPaymentRepository = new PaymentRepository();
            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(
                    objCustomerRepository.GetAllcustomers(), objProductRepository.GetAllProducts(), objPaymentRepository.GetAllPaymentTypes());

            return View(objMultipleModels);
        }

        [HttpGet]

        public JsonResult getProductProductPrice(int productId)
        {
            decimal ProductPrice = miniProjectEntities.Products.Single(model => model.ProductId == productId).ProductPrice;
            return Json(ProductPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(OrderViewModel objOrderViewModel)
        {
            OrderRepository objOrderRepository = new OrderRepository();
            objOrderRepository.AddOrder(objOrderViewModel);
            /*string SuccessMessage = String.Empty;

            if (isStatus)
            {
                SuccessMessage = "Your Order Has Been Successfully Placed.";
            }
            else
            {
                SuccessMessage = "There Is Some Issue While Placing Order.";
            }*/
            return Json(data:"yahoo order successful", JsonRequestBehavior.AllowGet);
        }

     
      
    }
}

