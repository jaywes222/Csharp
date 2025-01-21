// See https://aka.ms/new-console-template for more information

using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt User for Input
            Console.WriteLine("Enter A No To Be Tested if it's a Prime No.");

            //Read & Parse Input
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Check If the No is Prime
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a PRIME NO");
                }
                else
                {
                    Console.WriteLine($"{number} is NOT a PRIME NO");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Enter A Valid Integer");
            }

            //Pause to View Results
            Console.ReadLine();
        }

        //Function to Check if Number is Prime
        static bool IsPrime(int number) {
            //Prime Nos Are >1
            if (number <= 1) return false;

            // Check divisors up to the square root of the no
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false; // No is divisble, so not prime
                }
            }
            return true; // No is PRIME
        }
    }
}
