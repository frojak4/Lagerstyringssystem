﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Matvare : Iproduct
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Egenskap { get; set; }

        public Matvare(string navn, double pris, string egenskap)
        {
            Navn = navn;
            Pris = pris;
            Egenskap = egenskap;
        }

        public void SkrivUtInfo()
        {
            
            Console.Write($"Navn: {Navn}\t\t");
            Console.Write($"Pris: {Pris}\t\t");
            Console.Write($"Utløpsdato: {Egenskap}");
            Console.WriteLine();
        }
    }
}
