using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal interface Iproduct
    {
        string Navn { get; set; }
        double Pris { get; set; }

        string Egenskap {  get; set; }
        void SkrivUtInfo();

    }
}
