using InsuranceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.ViewModels
{
    public class OrderInsuranceViewModel
    {
        public Car CarForInsurance { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
