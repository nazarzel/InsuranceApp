using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceApp.Entities;
using InsuranceApp.Repositories;
using InsuranceApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly IOrderRepository orderRepository;

        public InsuranceController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return await Task.Run(()=>View());
        }
        public async Task<IActionResult> InsuranceInformationForCarAsync([FromForm]OrderInsuranceViewModel orderData)
        {
            if(ModelState.IsValid)
            {
                var orderToCreate = new Order()
                {
                    Id = Guid.NewGuid(),
                    Car = orderData.CarForInsurance,
                    DayStart = DateTime.Today,
                    PaymentType = orderData.PaymentType,
                    Price = 119.99M,
                    ReminderSent = false,
                    PdfSent = false,
                };
                orderRepository.CreateNewOrderAsync(orderToCreate);
                return await Task.Run(() => RedirectToAction("PaymentForInsuranceAsync"));
            }
            return await Task.Run(() => View(orderData));
        }

    }
}