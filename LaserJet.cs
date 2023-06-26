using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tugasPertemuan11
{
    public class LaserJet : Printer
    {
        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("Jenis Printer : {0}", jenisPrinter);
            Console.WriteLine("LaserJet display dimension : 12*12");
            Console.WriteLine("LaserJet printer Printing...");
        }
    }
}