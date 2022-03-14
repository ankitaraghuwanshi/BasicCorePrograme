

using System;

namespace BasicCorePrograme
{

    class Factor
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number :");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= number; i++)

            {
                if (number % i == 0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not a prime number");
            }
           
        }
    }

}