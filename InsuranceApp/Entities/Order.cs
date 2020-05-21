using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Entities
{
    [Table("Orders")]
    public class Order
    {
        public Guid Id { get; set; }
        public IdentityUser User { get; set; }
        public Car Car { get; set; }
        public decimal Price { get; set; }
        public Offer Offer { get; set; }
        public DateTime DayStart { get; set; }
        public PayStatus PayStatus { get; set; }
        public OrderStatus OrderStatus { get; set; }
        
    }
}
