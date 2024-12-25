using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemUsingCSharp;
public class Subject
{
    public Subject(int v1, string v2)
    {
        V1 = v1;
        V2 = v2;
    }

    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public Exam SubjectExam { get; set; }
    public int V1 { get; }
    public string V2 { get; }

    public void CreateExam()
    {
        int ExamType, Time, NumberOfQuestion;
        do
        {
            Console.WriteLine("Enter 1 for Practical Exam Or 2 For Final Exam : ");
        }
        while(!int.TryParse(Console.ReadLine() , out ExamType) && ExamType < 1 || ExamType > 2);

        do
        {
            Console.WriteLine("Enter Time Of Exam (30 to 180) Min : ");
        }
        while (!int.TryParse(Console.ReadLine(), out Time) && Time < 30 || Time >180);

        do
        {
            Console.WriteLine("Enter Number Of Questions : ");
        }
        while (!int.TryParse(Console.ReadLine(), out NumberOfQuestion));

        if(ExamType == 1)
        {
            SubjectExam = new PracticalExam(Time , NumberOfQuestion);
        }
        else
        {
            SubjectExam = new FinalExam(Time, NumberOfQuestion);
        }
        Console.Clear();
        SubjectExam.CreateListOfQuestions();
    }
}
