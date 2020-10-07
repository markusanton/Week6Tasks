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
            int max = randomArray.Max();
            int min = randomArray.Min();

            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}
