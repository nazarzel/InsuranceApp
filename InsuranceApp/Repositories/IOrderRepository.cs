using InsuranceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Repositories
{
    public interface IOrderRepository
    {
        void CreateNewOrderAsync(Order order);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(Guid orderId);
        void UpdateOrder(Order orderToUpdate);
        void DeleteOrder(Order orderToDelete);
        void SaveAsync();
    }
}
