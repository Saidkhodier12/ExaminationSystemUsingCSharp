using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemUsingCSharp;
public class PracticalExam : Exam
{
    public PracticalExam(int _time, int _numberOfuestion) : base(_time, _numberOfuestion)
    {
    }

    public override void CreateListOfQuestions()
    {
        ListOfQuestions = new Question[NumberOfQuestion];
        for (int i = 0; i < ListOfQuestions.Length; i++)
        {
            ListOfQuestions[i] = new MCQQuestion();
            ListOfQuestions[i].AddQuestion();
            Console.Clear();
        }
    }

    public override void ShowExam()
    {
        foreach (var question in ListOfQuestions)
        {
            Console.WriteLine(question);
            for (int i = 0; i < question.AnswerList.Length; i++)
            {
                Console.WriteLine(question.AnswerList[i]);
            }
            Console.WriteLine("-------------------------------");

            int UserAnswerId;
            do
            {
                Console.WriteLine("Enter Number Of You Answer ");
            } 
            while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 3);
          
            Console.WriteLine("------------");
        }
        Console.Clear();
        Console.WriteLine("Right Answers :");
        for(int i = 0;i < ListOfQuestions.Length;i++)
        {
            Console.WriteLine($"Right Answer Of Question {i+1} : {ListOfQuestions[i].RightAnswer.AnswerText}");
        }

    }
}
