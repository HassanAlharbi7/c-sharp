using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is my first program
            int x = 0, y = 0;
            double result = 0;

            Console.WriteLine("Please Enter The First Number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Second Number:");
            y = Convert.ToInt32(Console.ReadLine());

            result = x + y;

            Console.WriteLine("The sum = " + result);
            Console.ReadKey();
        }
    }
}
