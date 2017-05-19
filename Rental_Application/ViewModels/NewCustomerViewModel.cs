using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental_Application.Models;

namespace Rental_Application.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer customer { get; set; }

    }
}