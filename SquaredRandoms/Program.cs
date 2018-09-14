using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Hello User! Press enter to generate a list of random numbers!");
            Console.ReadLine();

            //1.) Random Numbers

           List <int> theMostRandom = new List<int>();
            for (int i = 0; i < 20; i++ )
            {
                theMostRandom.Add(rand.Next(1, 51));

            }

            foreach (int randomNumber in theMostRandom)
            {
                Console.WriteLine("Randoms: {0}" , randomNumber);
            }
            Console.WriteLine("Press enter to get the square root of each number in this list...");
            Console.ReadLine();

            //2.) Square the list of random numbers

            List<int> squareThem = new List<int>();

            foreach (int randomNumber in theMostRandom )
            {
                var squared = randomNumber * randomNumber;
                squareThem.Add(squared);
               
            }

            foreach (int randomNumber in squareThem)
            {
                Console.WriteLine("Squared Up: {0} ", randomNumber);
            }
            Console.WriteLine("Press enter to remove all of the even numbers from this list...");
            Console.ReadLine();

            //3.) Remove any odd number from the list of numbers.

            List<int> oddNumbers = new List<int>(squareThem);

            foreach (int even in oddNumbers)
            {
                if (even % 2 == 0)
                   squareThem.Remove(even);
            }

            foreach (int odd in squareThem)
            {
                Console.WriteLine("Well that's odd: {0} ", odd);
            }
 
           Console.WriteLine("Press enter to exit program. -Stix");
           Console.ReadLine();
        }
    }
}
