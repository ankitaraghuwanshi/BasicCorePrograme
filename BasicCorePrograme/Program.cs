

using System;

namespace BasicCorePrograme
{

    class PowerOfNum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of N :");
            int limit = int.Parse(Console.ReadLine());
           
            if (limit < 31)
            {
                int powerOf = (int)Math.Pow(2, limit);
                Console.WriteLine("2 is the power of :"+ limit);
                Console.WriteLine("= " + powerOf);

            }
            else
            {
                Console.WriteLine("Numberis less then 31");
            }
            
        }
    }


}