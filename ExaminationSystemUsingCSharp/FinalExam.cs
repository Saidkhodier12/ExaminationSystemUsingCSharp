using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemUsingCSharp;

public class FinalExam : Exam
{
    public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
    {
    }

    public override void CreateListOfQuestions()
    {
        ListOfQuestions = new Question[NumberOfQuestion];

        for (int i = 0; i < ListOfQuestions.Length; i++)
        {
            int choice;
            do
            {
                Console.WriteLine("enter 1 for MCQ or 2 for True/False Question");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2);

            Console.Clear();
            if (choice == 1)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].AddQuestion();
            }
            else if (choice == 2)
            {
                ListOfQuestions[i] = new TFQuestion();
                ListOfQuestions[i].AddQuestion();
            }

        }
    }
    public override void ShowExam()
    {
        int totalMarks = 0, Grade = 0;

        for (int i = 0; i < ListOfQuestions.Length; i++)
        {
            var Question = ListOfQuestions[i];
            Console.WriteLine($"Question ({i + 1}): {Question.Body}");
            for (int j = 0; j < Question.AnswerList.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {Question.AnswerList[j].AnswerText}");
            }
            Console.WriteLine("---------------------------");
            int UserAnswerId;
            do
            {
                Console.WriteLine("Enter the number of your answer:");
            }
            while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > Question.AnswerList.Length);
            Question.UserAnswer = new Answer
            {
                AnswerId = UserAnswerId,
                AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText
            };
            if (Question.RightAnswer.AnswerId == Question.UserAnswer.AnswerId)
            {
                Grade += Question.Marks;
            }

            totalMarks += Question.Marks;

            Console.WriteLine("---------------------------");
            Console.Clear();
        }

        
        for (int i = 0; i < ListOfQuestions.Length; i++)
        {
            Console.WriteLine($"Question ({i + 1}): {ListOfQuestions[i].Body}");
            Console.WriteLine($"Your answer: {ListOfQuestions[i].UserAnswer.AnswerText}");
            Console.WriteLine($"Right answer: {ListOfQuestions[i].RightAnswer.AnswerText}");
            Console.WriteLine("---------------------------");
        }
        Console.WriteLine($"Your grade is {Grade}/{totalMarks}");

    }

}