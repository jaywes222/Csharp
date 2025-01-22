using System;
using System.Linq;

namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");

            // Get user input & validate
            if (!int.TryParse(Console.ReadLine(), out int days) || days <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
                return;
            }

            int[] temperatures = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            // Random weather data generation
            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            // Daily weather report
            Console.WriteLine("\nWeather Report:");
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: {weatherConditions[i]} with {temperatures[i]}°C");
            }

            // Summary statistics
            double avgTemp = CalculateAvgTemp(temperatures);
            int maxTemp = temperatures.Max();
            int minTemp = temperatures.Min();
            string mostCommonCondition = MostCommonConditions(weatherConditions);

            Console.WriteLine($"\nSummary Statistics:");
            Console.WriteLine($"Average Temperature: {avgTemp:F2}°C");
            Console.WriteLine($"Maximum Temperature: {maxTemp}°C");
            Console.WriteLine($"Minimum Temperature: {minTemp}°C");
            Console.WriteLine($"Most Common Condition: {mostCommonCondition}");

            Console.ReadKey();
        }

        // Calculate average temperature
        static double CalculateAvgTemp(int[] temperatures)
        {
            return temperatures.Average();
        }

        // Find the most common weather condition
        static string MostCommonConditions(string[] conditions)
        {
            return conditions
                .GroupBy(condition => condition)
                .OrderByDescending(group => group.Count())
                .First().Key;
        }
    }
}
