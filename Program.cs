// See https://aka.ms/new-console-template for more information
using System;
namespace PrimeNumbers
{
    class Program
    {
        //Prime Number: A prime number is greater than 1 and divisible only by 1 and itself.
        static void Main(string[] args) {
            // Reading a Number from the Console
            Console.WriteLine("Enter Number to be tested as A Prime No");

            // Storing it in a variable
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            // Integer Variable for Counting Remainder of the Modulo Operation
            int divisor = 0;

            // For Loop till a given number starting from 1
            // 0 and 1 are not prime numbers
            for (int i = 1; i <= number; i++)
            {
                //If Statement: Checks the modulus of the value of the number variable
                // Condition: Equal to 0 or Not
                if (number % i == 0)
                {
                    // If modulus is 0 then the value of the K variable increases
                    divisor++;
                }
            }
                if (divisor == 2)
                {
                    // If K is equal to 2 it means it has 2 factors; 1 & Itself= PRIME NO
                    //Print a msg to the Console
                    Console.WriteLine("Entered Number is A Prime No");
                }
                else
                {
                    // If divisor isnt equal to 2 it means it has more than 2 factors= NOT A PRIME NO
                    //Print a msg to the Console
                    Console.WriteLine("Entered Number is NOT A Prime No");
                }
                Console.ReadLine();
            }
        }
    }
