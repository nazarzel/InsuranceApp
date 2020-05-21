﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InsuranceApp.Domain.Entities
{
    [Table("CarTypes")]
    public class CarType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
