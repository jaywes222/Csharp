namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The No Of Days To Simulate");
            //Get User Input & Validate
            if (!int.TryParse(Console.ReadLine(), out int days) || days <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
                return;
            }

            int[] temp = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            //Random Weather Data Generation
            for (int i = 0; i < days; i++)
            {
                temp[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            //Daily Weather Report
            Console.WriteLine("\nWeather Report:");
            for(int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: {weatherConditions[i]} with {temp[i]}°C");
            }

            //Summary Statistics
            Console.WriteLine($"\n\nAverage Temp is: {CalculateAvgTemp(temp)}°C");
            Console.WriteLine($"The MAX Temp is: {temp.Max()}°C");
            Console.WriteLine($"The MIN Temp is: {temp.Min()}°C");
            Console.WriteLine($"The MOST COMMON Condition is: {MostCommonConditions(weatherConditions)}");
            //Console.WriteLine($"The MIN Temp is: {MinTemp(temp)}");

            Console.ReadKey();

        }

        static string MostCommonConditions(string[] conditions)
        {
            int maxCount = 0;
            string mostCommon = conditions[0];

            for(int i =0; i < conditions.Length; i++)
            {
                int tempCount = 0;

                for(int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                    if(tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        mostCommon = conditions[i];
                    }
                }
            }
            return mostCommon;
        }

        static double CalculateAvgTemp(int[] temp)
        {
            double sum = 0;

            for(int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
            }

            //foreach(int i in temp)
            //{
            //    sum += i;
            //}

            double tempAvg = sum / temp.Length;

            return tempAvg;

        }

        //static int MinTemp(int[] temp)
        //{
        //    int min = temp[0];

        //    foreach(int i in temp)
        //    {
        //        if (i < min)
        //        {
        //            min = temp;
        //        }
        //    }

        //    return min;
        //}
    }
}
