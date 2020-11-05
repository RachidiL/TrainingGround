using System;

namespace RandomNumberDemo
{
    class Program
    {
        // If you'r writting something that hase to be absolutly random
        // than a cryptographic library is the way to go
        // it is typicaly for passwords!!!
        //maybe "RNGCryptoServiceProvider"
        static void Main(string[] args)
        {
            Random random = new Random(); // it is not thread save - for thread saveness it schould be wraped into a thread save wraper

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
                // SimpleMethod(random);
            }
            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            // Rondom ranodm = new Random() - don't do it
            Console.WriteLine(random.Next());
        }
    }
}
