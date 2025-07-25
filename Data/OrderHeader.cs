﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class OrderHeader
    {
        public int Id { get; set; }
        [Required]
        //User placing Order
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Status { get; set; }

        [Display(Name ="Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}
