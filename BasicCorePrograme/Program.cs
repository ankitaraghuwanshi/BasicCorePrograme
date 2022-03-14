

using System;

namespace BasicCorePrograme
{
    class EvenOdd
    {

        public static void Main(string[] args)
        {


            int number;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.Write("Even Number");
            }

            else
            {
                Console.Write("Odd Number");
            }


        }


    }

}