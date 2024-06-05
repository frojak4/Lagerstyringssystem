using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Lager
    {
        public List<Iproduct> Products { get; set; }

        public Lager(List<Iproduct> products)
        {
            Products = products;
        }
    }
}
