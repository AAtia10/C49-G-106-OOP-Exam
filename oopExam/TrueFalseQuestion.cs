using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark , Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {

        }
    }
}
