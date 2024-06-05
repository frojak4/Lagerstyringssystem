using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class App
    {
        Lager lager;
        public void Run()
        {
            createLager();

            while(true){
                Console.Clear();
                Console.WriteLine("Kva vil du gjere?");
                Console.WriteLine("1. Legge til produkt i lager");
                Console.WriteLine("2. Fjerne produkt fra lager");
                Console.WriteLine("3. Sjå alle lager-produkter");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    addProduct();
                }
            }
        }

        public void createLager()
        {
            List<Iproduct> products = new List<Iproduct>()
            {
                new Elektronikk("Nintendo Switch", 2300, "24"),
                new Elektronikk("Iphone 15", 12000, "12"),
                new Klær("Prada Veske", 34000, "Medium"),
                new Klær("Umbro shorts", 200, "32"),
                new Matvare("Brød", 12, "12.30"),
                new Matvare("Banan", 7, "07.06")
            };
            lager = new Lager(products);

    }

        public void addProduct()
        {
            Console.Clear();
            Console.WriteLine("Korleis produkt vil du legge til?");
            Console.WriteLine("1. Elektronikk");
            Console.WriteLine("2. Klær");
            Console.WriteLine("3. Matvare");
            string type = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Kva er navnet på produktet ditt?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Kva er prisen på ditt produkt?");
            string price = Console.ReadLine();
            double pricedbl = Convert.ToInt32(price);

            switch (type)
            {
                case "1":
                    Console.WriteLine("Kor lang garanti har produktet ditt?");
                    string ElEgenskap = Console.ReadLine();
                    Console.Clear();
                    Elektronikk newEl = new Elektronikk(name, pricedbl, ElEgenskap);
                    lager.Products.Add(newEl);
                    Console.WriteLine("Produkt lagt til.");
                    Console.ReadKey(true);
                    break;
                case "2":
                    Console.WriteLine("Korleis størrelse har produktet ditt?");
                    string KlærEgenskap = Console.ReadLine();
                    Console.Clear();
                    Klær newKlær = new Klær(name, pricedbl, KlærEgenskap);
                    lager.Products.Add(newKlær);
                    Console.WriteLine("Produkt lagt til.");
                    Console.ReadKey(true);
                    break;
                case "3":
                    Console.WriteLine("Korleis størrelse har produktet ditt?");
                    string MatEgenskap = Console.ReadLine();
                    Console.Clear();
                    Matvare newMat = new Matvare(name, pricedbl, MatEgenskap);
                    lager.Products.Add(newMat);
                    Console.WriteLine("Produkt lagt til.");
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("Something wrong happened!");
                    Console.ReadKey(true);
                    break;
            }

            


        }
    }
}
