using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingPracticeProblems
{
    public static class EvenOrOdd
    {
        public static void Numcheck()
        {
            Console.WriteLine("enter the num");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine(num + " is even");
                    break;
                case 1:
                    Console.WriteLine(num + " is odd");
                    break;
            }
        }
    }
}
