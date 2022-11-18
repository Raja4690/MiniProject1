using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiniProject1.Models;

using System.Web.Mvc;
namespace MiniProject1.Repositories
{
    public class PaymentRepository
    {
        private MiniProject1Entities2 objminiProjectEntities;

        public PaymentRepository()
        {
            objminiProjectEntities = new MiniProject1Entities2();
        }

        public IEnumerable<SelectListItem> GetAllPaymentTypes()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objminiProjectEntities.PaymentTypes
                                    select new SelectListItem
                                    {
                                        Text = obj.PaymentMode,
                                        Value = obj.PaymentId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}

