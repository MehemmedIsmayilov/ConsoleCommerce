using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Seller : Person
    {
        public string Telefon { get; set; }
        public string Pin { get; set; }
        public string SeriyaNum { get; set; }
    }
}
