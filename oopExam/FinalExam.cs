using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeInMinutes, Question[] questions) : base(timeInMinutes, questions)
        {
        }

        public override void ShowExam()
        {
            int grade = 0;
            int totalMark = 0;

            int[] studentAnswers = new int[NumberOfQuestions];

            Console.WriteLine("\n========== FINAL EXAM ==========");
            Console.WriteLine($"Time: {TimeInMinutes} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"\nQuestion {i + 1}:");
                question.DisplayQuestion();

                totalMark += question.Mark;

                studentAnswers[i] = ReadAnswer();
            }

            Console.WriteLine("\n========== EXAM RESULT ==========");

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine($"\n{question}");

                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine(answer);
                }

                Console.WriteLine(
                    $"Your Answer: {studentAnswers[i]}"
                );

                Console.WriteLine(
                    $"Right Answer: {question.RightAnswer}"
                );

                if (question.CheckAnswer(studentAnswers[i]))
                {
                    grade += question.Mark;
                }
            }

            Console.WriteLine($"\nYour Grade: {grade} / {totalMark}");
        }

        private int ReadAnswer()
        {
            int answerId;

            Console.Write("Enter Answer ID: ");

            while (!int.TryParse(Console.ReadLine(), out answerId))
            {
                Console.Write("Enter a valid number: ");
            }

            return answerId;
        }
    }
}
