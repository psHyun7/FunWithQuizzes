using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class QuestionTrueFalse : Question
    {
        public string CorrectAnswer { get; set; }
        public override bool IsCorrect()
        {
            UserAnswer = this.UserAnswer.ToUpper();
            if (UserAnswer == "TRUE")
            {
                UserAnswer = "T";
            }
            if (UserAnswer == "FALSE")
            {
                UserAnswer = "F";
            }
            if (UserAnswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"True or False: {QuestionText}.";
        }

        public override bool Equals(object obj)
        {
            return obj is QuestionTrueFalse @false &&
                   QuestionText == @false.QuestionText &&
                   CorrectAnswer == @false.CorrectAnswer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(QuestionText, CorrectAnswer);
        }

        public QuestionTrueFalse(string questionText, string correctAnswer) : base(questionText)
        {
            CorrectAnswer = correctAnswer;
        }

    }
}
