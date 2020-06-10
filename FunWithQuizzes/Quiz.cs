using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Quiz
    {
        public List<Question> Questions { get; set; }
        public double Grade { get; set; }
        private string Introduction = "Welcome to the world's easiest quiz: \n";

        public void AddQuestion(Question question)
        {
            if (Questions.Contains(question))
            {
                Console.WriteLine("That Question Already Exists in this quiz!");
            }
            else
            {
                Questions.Add(question);
            }

        }

        public void RemoveQuestion(Question question)
        {
            if (Questions.Contains(question))
            {
                Questions.Remove(question);
            }
            else
            {
                Console.WriteLine("That Question doesn't exist in this quiz!");
            }
        }

        public void ConductTest()
        {
            int i = 1;
            Console.WriteLine(Introduction);
            foreach (Question question in Questions)
            {
                Console.WriteLine("Question #" + i + ":\n " + question.ToString());
                question.UserAnswer = Console.ReadLine();
                
                i++;
            }
        }
        public double GradeQuiz()
        {
            int numCorrect = 0;
            foreach (Question question in Questions)
            {
                if (question.IsCorrect())
                {
                    numCorrect++;
                }
            }
            Grade = numCorrect / Questions.Count;
            return Grade;
        }
    }
}
