

using System;

namespace BasicCorePrograme
{

    class Divide
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend :");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor :");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("dividend:{0} divisor :{1}", dividend, divisor);
            Console.WriteLine("quotient= " + quotient);
            Console.WriteLine("remainder = " + remainder);
            
        }

    }

}