using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tugasPertemuan11
{
    public class Epson : Printer
    {
        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("Jenis Printer : {0}", jenisPrinter);
            Console.WriteLine("Epson display dimension : 10*11");
            Console.WriteLine("Epson printer Printing...");
        }
    }
}