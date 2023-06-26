using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tugasPertemuan11
{
    public abstract class Printer
    {
        public string jenisPrinter { get; set; }
        public abstract void print();
    }
}