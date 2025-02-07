using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.Answer;
using Examination_system.Question;

namespace Examination_system.exams
{ 
    public class PracticalExam : Exam
    {
        public string? SubjectName { get; set; }
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }
        public override void CreateExam()
        {
            Console.Write("Enter the subject name: ");
            SubjectName = Console.ReadLine();
            Console.WriteLine($"Subject: {SubjectName}");

            Console.WriteLine("Creating a Practical Exam...");
            Console.WriteLine("--------------");

            for (int i = 0; i < NumberOfQuestions; i++)

            {
                Console.WriteLine($"Enter details for Question {i + 1}:");
                Console.Write("Enter question body: ");
                string? body = Console.ReadLine();
                Console.WriteLine("--------------");
                int mark;
                    Console.Write("Enter the mark for this question: ");
                    while (!int.TryParse(Console.ReadLine(), out mark))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.Write("Enter the mark for this question: ");
                    }
                Console.WriteLine("--------------");
                int numOptions;
                Console.Write("Enter the number of options: ");
                while (!int.TryParse(Console.ReadLine(), out numOptions) || numOptions < 2)
                {
                    Console.WriteLine("Please enter at least 2 options.");
                }
                Console.WriteLine("--------------");
                Answers[]? AnswerList = new Answers[numOptions];
                for (int x = 0; x < numOptions; x++)
                {
                    Console.Write($"Enter option {x + 1}: ");
                    AnswerList[x] = new Answers(x + 1, Console.ReadLine());
                }
                Console.WriteLine("--------------");
                int correctAnswer;
                Console.Write("Enter the correct answer number: ");
                while (!int.TryParse(Console.ReadLine(), out correctAnswer) || correctAnswer < 1 ||
                    correctAnswer > numOptions)
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option number.");
                }
                Questions.Add(new MCQQuestion("MCQ", body, mark, AnswerList, correctAnswer));
            }
        }
    }
}
