using System.Diagnostics;

namespace ExaminationSystemUsingCSharp;

internal class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject(1, "C Shrap");
        subject.CreateExam();
        Console.Clear();
        Console.WriteLine("Do You Start The Exam (Y / N)");
        char c = char.Parse(Console.ReadLine());
        if (c == 'Y' || c == 'y')
        {
            Console.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            subject.SubjectExam.ShowExam();
            Console.WriteLine($"Taken Time : {sw.Elapsed}");
        }
        else
        {
            Console.WriteLine("Thank You !");
        }
    }
}
