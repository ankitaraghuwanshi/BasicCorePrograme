

using System;

namespace BasicCorePrograme
{
    class LargestNumber
    {
        public static void Main(string[] args)
        {
            int first, second, third;
            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("largest number : " + first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("largest number : " + second);
            }
            else
            {
                Console.WriteLine("largest number : " + third);
            }

        }
    }
}

 