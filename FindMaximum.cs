using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingPracticeProblems
{
    public static class FindMaximum
    {
         public static void GreatestNo()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three numbers:");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 || num1 > num3)
            {
                Console.Write("The 1st Number is the greatest among three. \n\n");
            }
            else if (num2 > num1 || num2 > num3)
            {
                Console.Write("The 2nd Number is the greatest among three. \n\n");
            }
            if (num3 > num2 || num3 > num1)
            {
                Console.Write("The 3rd Number is the greatest among three. \n\n");
            }
        }
    }
}
