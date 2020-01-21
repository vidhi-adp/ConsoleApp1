using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Device name: " + Environment.MachineName);
            Console.WriteLine("64 bit system: " + Environment.Is64BitOperatingSystem);
            Console.WriteLine("User name: " + Environment.UserName);
            Console.ReadLine();
        }
    }
}
