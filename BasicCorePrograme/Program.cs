

using System;

namespace BasicCorePrograme
{
    class SwapNumber
    {
        public static void Main(string[] args)
        {
            int numA, numB, temp;
            Console.WriteLine("Input the First Number : ");
            numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            numB = int.Parse(Console.ReadLine());
            temp = numA;
            numA = numB;
            numB = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + numA);
            Console.Write("\nSecond Number : " + numB);
            Console.Read();
        }    
    }


}

