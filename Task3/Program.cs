using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; ++i)
                randomArray[i] = rnd.Next(1, 11);
           
            int minint = randomArray[0];
            int maxint = randomArray[0];
            
            foreach (int value in randomArray)
            {
                if (value < minint) minint = value;
                if (value > maxint) maxint = value;
            }
            Console.WriteLine($"Min: {minint}");
            Console.WriteLine($"Max: {maxint}");

        }
    }
}
