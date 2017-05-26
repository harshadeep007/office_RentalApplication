using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rental_Application.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public String MembershipName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte UnKnown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}