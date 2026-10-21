using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark , Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {
        }
    }
}
