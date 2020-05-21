using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace InsuranceApp.Domain.Entities
{
    [Table("Cars")]
    public class Car
    {
        public Guid Id { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string Vin { get; set; }
        public CarType CarType { get; set; }
        //public IdentityUser
    }
}
