using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithQuizzes
{
    class QuestionMultipleChoice : Question
    {
        public string CorrectAnswer { get; set; }
        public override bool IsCorrect()
        {
            UserAnswer = UserAnswer.ToUpper().Trim();
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
            string output= "";
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

        public QuestionMultipleChoice(string questionText, 
            List<string> answerChoices, string correctAnswer) 
            : base(questionText, answerChoices)
        {
            CorrectAnswer = correctAnswer;
        }


    }
}
