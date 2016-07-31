using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegC_chap1_consoleapp
{
    class Program
    {
        static void MultiplyTwoNumbers (int a, int b)
        {
            int product = a * b;
            Console.WriteLine(product);
        }
        static void AddTwoNumbers (int c, int d)
        {
            int sum = c + d;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            MultiplyTwoNumbers(2, 3);
            AddTwoNumbers(4, 5);
            Console.ReadLine();
        }
    }
}
