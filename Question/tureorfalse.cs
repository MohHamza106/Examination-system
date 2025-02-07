using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.Answer;

namespace Examination_system.Question
{  
    public class TrueFalseQuestion : Questions
    {
        public TrueFalseQuestion(string? header, string? body, int mark, int rightAnswer)
       : base(header, body, mark, new Answers[]
       {
            new Answers(1, "True"),
            new Answers(2, "False")
       }, rightAnswer)
        { }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"[True or False] {Header}");
            Console.WriteLine($"{Body} ");
            Console.WriteLine($"Mark: {Mark}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine(answer);
            }
        }
        public override bool CheckAnswer()
        {
            Console.Write("Enter your answer (1 for True, 2 for False): ");
            if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == RightAnswer)
            {
                Console.WriteLine("Correct!");
                return true;
            }
            Console.WriteLine("Incorrect!");
            return false;
        }


    }
}
