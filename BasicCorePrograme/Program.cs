

using System;

namespace BasicCorePrograme
{
    class VowelConsonant
    {
        public static void Main(string[] args)
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

        }
    }
}


 