using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Base;

namespace Core.Entities
{
    public class Product:BaseEntitiy
    {
        public string MehsulAd { get; set; }
        public string Qiymet { get; set; }
        public string Say { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int SellerID { get; set; }
        public Seller Seller { get; set; }
    }
}
