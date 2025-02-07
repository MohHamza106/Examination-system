using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.Question;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examination_system.exams
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Questions> Questions { get; set; } = new List<Questions>();
        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }
        public abstract void CreateExam();
        public void StartExam()
        {
            int totalScore = 0;
            Console.WriteLine("\n=== Exam Started ===");

      
            int remainingTime = Time * 60;
            bool timeUp = false;

      
            Thread timerThread = new Thread(() =>
            {
                while (remainingTime > 0)
                {
                    Thread.Sleep(1000); 
                    remainingTime--;
                }
                timeUp = true;
                Console.WriteLine("\nTime is up! Submitting exam...");
            });

            timerThread.Start(); 

            foreach (var question in Questions)
            {
                if (timeUp)
                {
                    Console.WriteLine("\nTime expired! Submitting the exam...");
                    break; 
                }

                question.DisplayQuestion();
                bool isCorrect = question.CheckAnswer();

                if (isCorrect)
                {
                    totalScore += question.Mark ;
                }
            }

            Console.WriteLine($"\nYour Total Score: {totalScore}/{GetTotalMarks()}");
        }

        private int GetTotalMarks()
        {
            int total = 0;
            foreach (var q in Questions)
            {
                total += q.Mark ;
            }
            return total;
        }
    }

    
}
