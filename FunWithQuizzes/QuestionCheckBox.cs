using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithQuizzes
{
    class QuestionCheckbox : Question
    {
        public string CorrectAnswer { get; set; }
        public override bool IsCorrect()
        {
            UserAnswer = UserAnswer.ToUpper().Trim();
            char[] UserAnswerArr = UserAnswer.ToCharArray();
            char[] CorrectAnswerArr = CorrectAnswer.ToCharArray();
            Array.Sort(UserAnswerArr);
            if (UserAnswerArr == CorrectAnswerArr)
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
            string output = "";
            output = output + QuestionText + ":";
            foreach (string answerChoice in AnswerChoices)
            {
                output = output + "\n" + answerChoice;
            }
            return output;
        }

        public override bool Equals(object obj)
        {
            return obj is QuestionMultipleChoice choice &&
                   QuestionText == choice.QuestionText &&
                   EqualityComparer<List<string>>.Default.Equals(AnswerChoices, choice.AnswerChoices) &&
                   CorrectAnswer == choice.CorrectAnswer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(QuestionText, AnswerChoices, CorrectAnswer);
        }

        public QuestionCheckbox(string questionText,
            List<string> answerChoices, string correctAnswer)
            : base(questionText, answerChoices)
        {
            CorrectAnswer = correctAnswer;
        }


    }
}
