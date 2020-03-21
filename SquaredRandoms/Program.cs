using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = GenerateAListOfRandomNumbers();
            var squaredNums =  randomNumbers.Select(number => number * number);  //transforms
            var evenNumbers = squaredNums.Where(squareNum => squareNum % 2 == 0); //filters
            Console.ReadKey();
        }

        private static List<int> GenerateAListOfRandomNumbers()
        {
            Random random = new Random();
            var randNums = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                var number = random.Next(1, 50);
                randNums.Add(number);
            }
            return randNums;

            
        }
    }
}
