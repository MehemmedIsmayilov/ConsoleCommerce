using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Abstract;
using Core.Entities;

namespace Application.Services.Concret
{
    public class AdminService : IAdminService
    {
        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void CreateSeller(Seller seller)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteSeller(int sellerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public List<Seller> GetAllSellers()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersBySellerId(int sellerId)
        {
            throw new NotImplementedException();
        }
    }
}
