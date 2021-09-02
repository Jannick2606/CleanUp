using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;


namespace CleanUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.GetDiskMetadata();
            Data.GetHardDiskSerialNumber();
            Logic.CPU();
            Logic.hovedLager();
            Logic.test();
            Logic.testhest();
            Console.WriteLine("process søgning");
            Logic.LISTAllServices();
            Console.ReadKey();

        } //slut main
    }
}
