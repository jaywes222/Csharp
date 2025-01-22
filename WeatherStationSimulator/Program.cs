namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The No Of Days To Simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temp = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temp[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine($"Average Temp is: {CalculateAvgTemp(temp)}");

            Console.ReadKey();

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
    }
}
