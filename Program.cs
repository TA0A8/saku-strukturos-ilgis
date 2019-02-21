using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuStrukturosIlgis
{
    class Program
    {
        static void Main(string[] args)
        {
            //  sukuriam saku struktura

            Saka saka1 = new Saka(1);
            Saka saka2 = new Saka(2);
            Saka saka3 = new Saka(3);
            Saka saka4 = new Saka(4);
            Saka saka5 = new Saka(5);
            Saka saka6 = new Saka(6);
            Saka saka7 = new Saka(7);
            Saka saka8 = new Saka(8);
            Saka saka9 = new Saka(9);
            Saka saka10 = new Saka(10);
            Saka saka11 = new Saka(11);
            saka1.vaikai.Add(saka2);
            saka1.vaikai.Add(saka3);
            saka2.vaikai.Add(saka4);
            saka2.vaikai.Add(saka5);
            saka4.vaikai.Add(saka6);
            saka3.vaikai.Add(saka7);
            saka3.vaikai.Add(saka8);
            saka8.vaikai.Add(saka9);
            //saka9.vaikai.Add(saka10);
            //saka10.vaikai.Add(saka11);


            Console.WriteLine("1-");
            Console.WriteLine("  2-");
            Console.WriteLine("     4-");
            Console.WriteLine("        6-");
            Console.WriteLine("     5-");
            Console.WriteLine("  3-");
            Console.WriteLine("     7-");
            Console.WriteLine("     8-");
            Console.WriteLine("        9-");
            //Console.WriteLine("           10-");
            //Console.WriteLine("              11-");

            List<Saka> path = saka1.gylis;


            int sktl = 0;
            path = saka1.gylis;
            foreach (Saka n in path)
                sktl++;

            Console.WriteLine("giliausias duotos strukturos lygis yra: " + sktl);

            Console.ReadKey();
        }
    }
}
