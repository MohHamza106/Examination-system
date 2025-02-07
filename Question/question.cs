using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.Answer;

namespace Examination_system.Question
{
    public abstract class Questions
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[] AnswerList { get; set; }
        public int RightAnswer { get; set; }
        protected Questions(string? header, string? body, int mark, Answers[] answerList, int rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }
        public abstract void DisplayQuestion();
        public abstract bool CheckAnswer();
    }

}
