using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.Answer;

namespace Examination_system.Question
{
    public class MCQQuestion : Questions
    {
        public MCQQuestion(string? header, string? body, int mark, Answers[] answerList, int rightAnswer)
            : base(header, body, mark, answerList, rightAnswer) { }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"[MCQ] {Header}");
        Console.WriteLine( $"Mark:{Mark}");
            Console.WriteLine($"question: {Body} ");
            foreach (var answer in AnswerList)            
                Console.WriteLine(answer);  
        }
        public override bool CheckAnswer()
        {
            Console.Write("Enter your answer (number): ");
            if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == RightAnswer)
            {
                Console.WriteLine("Correct");
                return true;
            }
            Console.WriteLine("Incorrect");
            return false;
        }

    }
}
