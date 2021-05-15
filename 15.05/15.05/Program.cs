using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите трехзначное число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 100;

            if (a == b)
            {
                Console.WriteLine("палиндром");
            }
            else
            {
                Console.WriteLine("не палиндром");
            }
            Console.ReadKey();

        }
    }
}
