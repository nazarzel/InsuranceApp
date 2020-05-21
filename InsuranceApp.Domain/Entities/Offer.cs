using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InsuranceApp.Domain.Entities
{
    [Table("Offers")]
    public class Offer
    {
        public int Id { get; set; }
    }
}
