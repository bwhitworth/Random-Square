using System;
using System.Collections.Generic;

namespace Random_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            Random random = new Random();

            var randomNumbersList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                var newRandomNumber = random.Next(1, 51);
                randomNumbersList.Add(newRandomNumber);
            }

            Console.WriteLine($"List of random numbers: {string.Join(", ", randomNumbersList)}");

            // With the resulting List, populate a new List that contains each number squared.

            var squaredNumbersList = new List<int>();

            for (int i = 0; i < randomNumbersList.Count; i++)
            {
                var squaredNumber = randomNumbersList[i] * randomNumbersList[i];
                squaredNumbersList.Add(squaredNumber);
            }

            Console.WriteLine($"\nSquares of those numbers: {string.Join(", ", squaredNumbersList)}");

            // Then remove any number that is odd from the list of squared numbers.

            var evenSquaredNumbersList = new List<int>();

            for (int i = 0; i < squaredNumbersList.Count; i++)
            {
                if (squaredNumbersList[i] % 2 == 0)
                {
                    evenSquaredNumbersList.Add(squaredNumbersList[i]);
                }
            }

            Console.WriteLine($"\nEven squares only: {string.Join(", ", evenSquaredNumbersList)}");

        }
    }
}
