using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Data.Repositories.Abstract
{
    public interface IAdminRepositery
    {
        List<Admin> Getall();
        Admin Get(int id);
        void add(Admin admin);
        void update(Admin admin);
        void delete(Admin admin);
    }
}
