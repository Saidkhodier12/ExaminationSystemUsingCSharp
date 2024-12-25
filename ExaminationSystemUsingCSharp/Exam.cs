using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemUsingCSharp;
public abstract class Exam
{
    public int Time {  get; set; }
    public int NumberOfQuestion {  get; set; }
    public Question[] ListOfQuestions { get; set; }
    protected Exam(int _time , int _numberOfuestion)
    {
        Time = _time;
        NumberOfQuestion = _numberOfuestion;
    }
    public abstract void ShowExam();
    public abstract void CreateListOfQuestions();

}
