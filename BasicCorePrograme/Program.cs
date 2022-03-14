

using System;

namespace BasicCorePrograme
{

    class CoinFlip
    {
        public bool HeadOrTails()
        {
            int coinHead = 1; // constant
            Random random = new Random();
            int coincheck = random.Next(0, 2);
            if (coincheck == coinHead)
            {
                Console.WriteLine("coin is Head");
                return true;
            }
            else
            {
                Console.WriteLine("coin is tails");
                return false;
            }
        }

    }

    class Leapyear
    {
        public bool LeapyearOrNot()
        {


            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
                return true;
            }
            
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
                Console.ReadLine();
            }
            return false;
            
        }

    }

    class PowerOfNum
    {
        public void PowerOfnum()
        {
            Console.WriteLine("Please enter the value of N :");
            int limit = int.Parse(Console.ReadLine());

            if (limit < 31)
            {
                int powerOf = (int)Math.Pow(2, limit);
                Console.WriteLine("2 is the power of :" + limit);
                Console.WriteLine("= " + powerOf);

            }
            else
            {
                Console.WriteLine("Numberis less then 31");
            }
            

        }
    }

    class HarmonicSeries
    {
        public int harmonicNumber()
        {
            int i = 1;
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                Console.Write("1/{0} +", i);

            }
            return 0;

        }
    }
    class Factor
    {

        public int PrimeNumber()
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
            return 0;
        }
    }
    class Divide
    {
        public int QuoAndRem()
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
            return 0;
        }

    }


    class SwapNumber
    {
        public int SwapingOfNumber()
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
            return 0;
        }

    }

    class EvenOdd
    {

        public int EvenOrOdd()
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
            return 0;

        }
    }

    class VowelConsonant
    {
        public string ConsonantOrVowel()
        {
            char alpha;
            Console.WriteLine("Enter a Alphabet : ");
            alpha = char.Parse(Console.ReadLine());

            if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u')
            {

                Console.WriteLine("alphabet is Vowel");

            }
            else
            {
                Console.WriteLine("alphabet is Consonant");
            }
            return "";
        }
    }


    class LargestNumber
    {
        public int LargestOfNumbers()
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
            return 0;
        }
    }


    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 for FLIPCOIN");
            Console.WriteLine("2 for LEAPYAER");
            Console.WriteLine("3 for TABLE OF 2^ ");
            Console.WriteLine("4 for HARMONIC NUMBER");
            Console.WriteLine("5 for FACTORS");
            Console.WriteLine("6 for COMPUTE QUOTIENT AND REMAINDER");
            Console.WriteLine("7 for SWAP THE NUMBER");
            Console.WriteLine("8 for NUMBER IS EVEN OR ODD");
            Console.WriteLine("9 for ALPHABET IS VOWEL OR CONSONENT");
            Console.WriteLine("10 for FINDING LARGEST NUMBER");
            Console.WriteLine("Enter the according to  above condition : \n");

            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    CoinFlip coinFlip = new CoinFlip();
                    coinFlip.HeadOrTails();
                    break;

                case 2:
                    Leapyear leapyear = new Leapyear();
                    leapyear.LeapyearOrNot();
                    break;

                case 3:
                    PowerOfNum powerOfNum = new PowerOfNum();
                    Console.WriteLine("Please enter the value of N :");
                    int limit = int.Parse(Console.ReadLine());
                    powerOfNum.PowerOfnum();
                    break;

                case 4:
                    HarmonicSeries harmonicSeries = new HarmonicSeries();
                    harmonicSeries.harmonicNumber();
                    break;

                case 5:
                    Factor factor = new Factor();
                    factor.PrimeNumber();
                    break;

                case 6:
                    Divide divide = new Divide();
                    divide.QuoAndRem();
                    break;

                case 7:
                    SwapNumber swapNumber = new SwapNumber();
                    swapNumber.SwapingOfNumber();
                    break;

                case 8:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenOrOdd();
                    break;

                case 9:
                    VowelConsonant vowelConsonant = new VowelConsonant();
                    vowelConsonant.ConsonantOrVowel();
                    break;

                case 10:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.LargestOfNumbers();
                    break;

                default:
                    Console.WriteLine("Please enter a valid number.");
                    break;
            }

        }
    }
}







