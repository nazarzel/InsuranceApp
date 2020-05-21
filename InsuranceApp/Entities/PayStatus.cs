using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Entities
{
    [Table("PayStatuses")]
    public class PayStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
