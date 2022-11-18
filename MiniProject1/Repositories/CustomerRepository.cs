using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject1.Models;

namespace MiniProject1.Repositories
{
    public class CustomerRepository
    {
        private readonly MiniProject1Entities2 objminiProjectEntities;
        public CustomerRepository()
        {
            objminiProjectEntities = new MiniProject1Entities2();
        }

        public IEnumerable<SelectListItem> GetAllcustomers()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objminiProjectEntities.Customers
                                    select new SelectListItem
                                    {
                                        Text = obj.CustomerName,
                                        Value = obj.CustomerId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}