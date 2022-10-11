using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingPracticeProblems
{
    public static class RemQuo
    {
        public static void Divide()
        {
            Console.WriteLine("enter the dividend");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the dividend:");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
