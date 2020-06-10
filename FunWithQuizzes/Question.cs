using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Text;

namespace FunWithQuizzes
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public List<string> AnswerChoices = new List<string>();
        public string UserAnswer { get; set; }

        public bool AnsweredCorrectly
        {
            get
            {
                return AnsweredCorrectly;
            }
            set
            {
                AnsweredCorrectly = IsCorrect();
            }
        }


        public abstract bool IsCorrect();

        public Question(string questionText)
        {
            QuestionText = questionText;
        }

        public Question(string questionText, List<string> answerChoices)
        {
            QuestionText = questionText;
            AnswerChoices = answerChoices;
        }
    }
}
