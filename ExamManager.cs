using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.exams;

namespace Examination_system
{
    internal class ExamManager
    {
        public static Exam CreateExam()
        {
           
            Console.Write("Enter the duration of the exam (in minutes): ");
            int time;
            while (!int.TryParse(Console.ReadLine(), out time) || time <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
                Console.Write("Enter the duration of the exam (in minutes): ");
            }
            Console.WriteLine("--------------");
            Console.Write("Enter the number of questions: ");
            int numberOfQuestions;
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
                Console.Write("Enter the number of questions: ");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Select Exam Type:\n 1 - Final\n2 - Practical");
            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
            {
                Console.WriteLine("Invalid choice! Please enter 1 for Final or 2 for Practical.");
            }

      
            if (examType == 1)
            {
                return new FinalExam(time, numberOfQuestions);
            }
            else
            {
                return new PracticalExam(time, numberOfQuestions);
            }
        }
    }
}
