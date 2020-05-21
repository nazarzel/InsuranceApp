using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace InsuranceApp.Entities
{
    [Table("Cars")]
    public class Car
    {
        public Guid Id { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string Vin { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public CarType CarType { get; set; }
        public IdentityUser Owner { get; set; }
    }
}
