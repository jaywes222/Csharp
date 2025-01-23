namespace Quiz_App_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Kenya?",
                    new string[] {"Paris", "Berlin", "Madrid", "Nairobi"},
                    3
                    ),

                new Question(
                    "What is 2+2?",
                    new string[] {"5", "4", "6", "8"},
                    1
                    ),
                 new Question(
                    "Who Wrote Hamblet?",
                    new string[] {"Goethe", "ShakeSpeare", "Austen", "Dickens"},
                    1
                    )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            //quiz.StartQuiz();


            Console.ReadKey();
        }
    }
}
