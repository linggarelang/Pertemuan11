using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tugasPertemuan11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new LaserJet();

            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");
            Console.Write("Piih Jenis Printer [1...3] : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: epson.jenisPrinter = "Epson"; epson.print(); break;
                case 2: canon.jenisPrinter = "Canon"; canon.print(); break;
                case 3: laserjet.jenisPrinter = "LaserJet"; laserjet.print(); break;
                default: epson.jenisPrinter = "Epson"; epson.print(); break;
            }
        }
    }
}