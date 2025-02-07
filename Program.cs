using Examination_system.exams;
using Examination_system.Question;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam exam = ExamManager.CreateExam();
            exam.CreateExam();
            Console.WriteLine("______________________________");
            Console.WriteLine("Do you went start exam (yes/ no)");
            string? startexam = Console.ReadLine();
            if (startexam == "y" || startexam == "yes")
            {
                exam.StartExam();
                Console.WriteLine(" end exam");
            }
            else Console.WriteLine("no now  start exam");
        }
    }
}
