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
            Logic.Cpu();
            Logic.HovedLager();
            Logic.Test();
            Logic.TestHest();
            Console.WriteLine("process søgning");
            Logic.ListAllServices();
            Console.ReadKey();

        } //slut main
    }
}
