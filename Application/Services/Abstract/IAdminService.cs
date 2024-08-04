using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Application.Services.Abstract
{
    public interface IAdminService
    {
        void CreateSeller(Seller seller);
        void CreateCustomer(Customer customer);
        void DeleteSeller(int sellerId);
        void DeleteCustomer(int customerId);
        List<Seller> GetAllSellers();
        List<Customer> GetAllCustomers();
        void CreateCategory(Category category);
        List<Order> GetOrdersByDate(DateTime date);
        List<Order> GetOrdersByCustomerId(int customerId);
        List<Order> GetOrdersBySellerId(int sellerId);
        List<Order> GetAllOrders();
    }
}
