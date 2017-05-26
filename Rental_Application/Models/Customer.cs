using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rental_Application.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Please Enter Customer Name")]
        [StringLength(255)]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        public bool IsSubscribed { get; set; }
        public MemberShipType MemberShipType { get; set; }
        [Display(Name ="MemberShip Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}