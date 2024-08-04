using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;
using Data.UnitOfWork.Abstract;

namespace Data.UnitOfWork.Concrete
{
    public class Unitofwork : IUnitofwork
        
    {
        private readonly AppDbContext _context;
        public Unitofwork()
        {
            _context = new AppDbContext();
        }
        public void commit()
        {
            throw new NotImplementedException();
        }
    }
}
