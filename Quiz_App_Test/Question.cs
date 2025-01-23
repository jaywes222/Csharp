using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App_Test
{
    internal class Question
    {
        //Properties
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        //Custom Constructor
        public Question(string questiontext, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questiontext;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        //Method
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
