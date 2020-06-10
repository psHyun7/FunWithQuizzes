using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FunWithQuizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionTrueFalse question1 = new QuestionTrueFalse("Polar Bears are White", "T");
            QuestionCheckBox question2 = new QuestionCheckBox("Which of the following colos are primary colors?", new List<string> { "a: Blue", "b: Red", "c: Green", "d: Yellow" }, "abd");
            QuestionMultipleChoice question3 = new QuestionMultipleChoice("Why did you take this quiz?", new List<string> { "a: Bored", "b: Just Because", "c: LaunchCode", "d: Huh?" }, "c");
            Quiz quiz1 = new Quiz();
            quiz1.AddQuestion(question1);
            quiz1.AddQuestion(question2);
            quiz1.AddQuestion(question3);

            quiz1.ConductTest();
            Console.WriteLine("\nThat Concludes the World's Easiest Test! \n");
            double grade = quiz1.GradeQuiz();
            Console.WriteLine($"You've Got {grade * 100}%!!");
        }
    }
}
