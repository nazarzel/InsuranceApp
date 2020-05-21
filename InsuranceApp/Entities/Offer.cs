using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InsuranceApp.Entities
{
    [Table("Offers")]
    public class Offer
    {
        public int Id { get; set; }
        public int numOfDays { get; set; }
        public CarType CarType { get; set; }
        public decimal Price { get; set; }
    }
}
