using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Height_Classification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[6];
            int shortCount = 0, averageCount = 0, tallCount = 0;

            Console.WriteLine("Enter 6 people's heights in cm:");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write($"Height {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    Console.Write($"Height {i + 1}: ");
                }
            }
            Console.WriteLine("\nHeight Classification Results:");
            for (int i = 0; i < heights.Length; i++)
            {
                string category;
                if (heights[i] < 150)
                {
                    category = "Short";
                    shortCount++;
                }
                else if (heights[i] <= 170)
                {
                    category = "Average";
                    averageCount++;
                }
                else
                {
                    category = "Tall";
                    tallCount++;
                }

                Console.WriteLine($"{heights[i]} cm: {category}");
            }
            Console.WriteLine("\nCategory Totals:");
            Console.WriteLine($"Short (<150 cm): {shortCount} people");
            Console.WriteLine($"Average (150-170 cm): {averageCount} people");
            Console.WriteLine($"Tall (>170 cm): {tallCount} people");
        }
    }
}
