using System;

class SimpleCalc
{
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator");
            //Prompt User for Num1
            Console.WriteLine("Enter Your Num1");
            //User Input & Validation
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid Input! Please Enter A Valid Num.");
                return;
            }

            //Prompt User for Num2
            Console.WriteLine("Enter Your Num2");
            //User Input & Validation
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid Input! Please Enter A Valid Num.");
                return;
            }

            //Prompt User for Arithmetic Operator
            Console.WriteLine("Enter an Arithmetic Operator: (+, -, *, /)");
            string operation = Console.ReadLine();

            //Perform the Operation
            double result = 0;
            bool isValidOperation = true;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division By Zero(0) is NOT ALLOWED!");
                        isValidOperation = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator! Please Use One of the Following: +,-,*,/");
                    isValidOperation = false;
                    break;
            }

            //Result for Valid operation
            if (isValidOperation)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }

            Console.WriteLine("Thank You for Using the SkeptiKrafts Simple Calculator! Adios!");

        }
}
