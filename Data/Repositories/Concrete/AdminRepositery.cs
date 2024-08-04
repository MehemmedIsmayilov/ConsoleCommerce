using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Data.Contexts;
using Data.Repositories.Abstract;

namespace Data.Repositories.Concrete
{
    public class AdminRepositery : IAdminRepositery
    {
        private readonly AppDbContext _unitOfWork;
        public AdminRepositery(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void add(Admin admin)
        {
            try
            {
                _unitOfWork.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }        }

        public void delete(Admin admin)
        {
            _unitOfWork.Admins.Remove(admin);
        }

        public Admin Get(int id)
        {
            return _unitOfWork.Admins.Find(id);
        }

        public List<Admin> Getall()
        {
            return _unitOfWork.Admins.ToList();
        }

        public void update(Admin admin)
        {
            _unitOfWork.Admins.Update(admin);
        }
    }
}
