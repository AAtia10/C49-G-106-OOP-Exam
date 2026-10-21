using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeInMinutes, Question[] questions) : base(timeInMinutes, questions)
        {
        }

        public override void ShowExam()
        {
            int[] studentAnswers = new int[NumberOfQuestions];

            Console.WriteLine("\n========== PRACTICAL EXAM ==========");
            Console.WriteLine($"Time: {TimeInMinutes} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                Questions[i].DisplayQuestion();

                studentAnswers[i] = ReadAnswer();
            }

            Console.WriteLine("\n========== CORRECT ANSWERS ==========");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i]);

                Console.WriteLine(
                    $"Your Answer ID: {studentAnswers[i]}"
                );

                Console.WriteLine(
                    $"Right Answer: {Questions[i].RightAnswer}"
                );
            }
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
