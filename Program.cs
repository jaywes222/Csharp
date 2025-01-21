using System;

class Avg_Calc
{
    static void Main()
    {
        int currentScore;
        int sum = 0;
        int counter = 0;

        Console.WriteLine("Enter Your Student's Scores. Enter -1 To Finish");

        do
        {
            Console.WriteLine("Enter Score: ");
            string studentInput = Console.ReadLine();

            //Input Validation
            if (int.TryParse(studentInput, out currentScore))
            {
                if (currentScore == -1)
                    break;

                if (currentScore >= 0) //Only Accepting Non-Negative Nos
                {
                    sum = sum + currentScore;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid Score! Please Enter A Non-Negative Number");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! Please Enter A Valid Number!");
            }
        } while (currentScore != -1);

        if (counter > 0)
        {
            int avg = sum / counter;
            Console.WriteLine($"\nThe Average Score is: {avg}");
        }
        else
        {
            Console.WriteLine("\nNo Scores Were Entered!");
        }
        Console.ReadKey();
    }
}