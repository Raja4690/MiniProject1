using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject1.Models;
namespace MiniProject1.Repositories
{
    public class ProductRepository
    {
        private readonly MiniProject1Entities2 objminiProjectEntities;
        public ProductRepository()
        {
            objminiProjectEntities = new MiniProject1Entities2();
        }

        public IEnumerable<SelectListItem> GetAllProducts()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objminiProjectEntities.Products
                                    select new SelectListItem
                                    {
                                        Text = obj.ProductName,
                                        Value = obj.ProductId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}