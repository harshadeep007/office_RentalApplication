using System;
using System.ComponentModel.DataAnnotations;


namespace Rental_Application.Dtos
{
    public class CustomerDto
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Name")]
        [StringLength(255)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        public bool IsSubscribed { get; set; }
        [Display(Name = "MemberShip Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]

        public DateTime? Birthdate { get; set; }
    }
}