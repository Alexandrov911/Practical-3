using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x");
            double x = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            if (x>0)
            {
                y=(Math.Pow(Math.Sin(x),2));

            }
            else  
            {
                y= 1 - 2 * Math.Sin(x*x);
            }
            Console.WriteLine("Ответ:"+ y);
            Console.ReadKey();


        }
    }
}
