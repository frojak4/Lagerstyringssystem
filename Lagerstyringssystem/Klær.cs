﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Klær
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Egenskap { get; set; }

        public Klær(string navn, double pris, string egenskap)
        {
            Navn = navn;
            Pris = pris;
            Egenskap = egenskap;
        }

        public void SkrivUtInfo()
        {
            Console.Clear();
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Pris: {Pris}");
            Console.WriteLine($"Størrelse: {Egenskap}");
        }
    }
}
