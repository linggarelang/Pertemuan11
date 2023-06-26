using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tugasPertemuan11
{
    public class Canon : Printer
    {
        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("Jenis Printer : {0}", jenisPrinter);
            Console.WriteLine("Canon display dimensions : 9.5*12");
            Console.WriteLine("Canon Printer Printing...");
        }
    }
}