using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App_Test
{
    internal class Quiz
    {
        //Variable
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        //Methods
        public void StartQuiz()
        {
            Console.WriteLine("Welcome To The Quiz");
            int questionNumber = 1; //Display Qtn Nos

            _questions = _questions.OrderBy(q => Guid.NewGuid()).ToArray();

            foreach(Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestions(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice)) 
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The Correct Answer is; {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults();

            //Replay
            Console.WriteLine("Replay?");
            string playAgain = Console.ReadLine()?.ToLower();

            if (playAgain == "y")
            {
                _score = 0;
                StartQuiz();
            }
            else
            {
                Console.WriteLine("Thank You for Participating!!!");
            }
        }
        private void DisplayQuestions(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for(int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(" ");
                Console.Write(i + 1);
                Console.ResetColor();

                Console.WriteLine($". {question.Answers[i]}");
            }
 
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your Answer (Number): ");
            string input = Console.ReadLine();
            int choice = 0;

            while(!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid Choice. Please Enter A No Btwn 1 & 4");
                input = Console.ReadLine();
            }

            return choice -1;//Adjusting to 0 Indexed Array
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Results");
            Console.ResetColor();

            Console.WriteLine($"Quiz Finished. Your Score is {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if(percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing");
            }
            Console.ResetColor();
        }
    }
}
