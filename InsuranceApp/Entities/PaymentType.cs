﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Entities
{
    [Table("PaymentTypes")]
    public class PaymentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
