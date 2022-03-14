

using System;

namespace BasicCorePrograme
{

    class CoinFlip
    {
        public static void Main(string[] args)
        {
            int coinHead = 1; // constant
            Random random = new Random();
            int coincheck = random.Next(0, 2);
            if (coincheck == coinHead)
            {
                Console.WriteLine("coin is head");

            }
            else
            {
                Console.WriteLine("coin is tails");

            }
        }

    }
}