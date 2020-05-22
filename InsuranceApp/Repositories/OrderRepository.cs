using InsuranceApp.Data;
using InsuranceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext context;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async void CreateNewOrderAsync(Order order)
        {
            await context.Orders.AddAsync(order);
            SaveAsync();
        }

        public void DeleteOrder(Order orderToDelete)
        {
            context.Orders.Remove(orderToDelete);
            SaveAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await context.Orders.OrderBy(o => o.DayStart).ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(Guid orderId)
        {
            return await context.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
        }

        public void UpdateOrder(Order orderToUpdate)
        {
            context.Orders.Update(orderToUpdate);
            SaveAsync();
        }
        public async void SaveAsync()
        {
            if (await context.SaveChangesAsync() > 0)
                throw new Exception("Saving the data has failed on save");
        }
    }
}
