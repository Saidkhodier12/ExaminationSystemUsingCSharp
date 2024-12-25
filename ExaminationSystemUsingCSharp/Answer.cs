using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemUsingCSharp;
public class Answer
{
    public int AnswerId {  get; set; }
    public string AnswerText { get; set; }
    public Answer()
    {
        
    }
    public Answer(int _id , string _name)
    {
        AnswerId = _id;
        AnswerText = _name;
    }
    public override string ToString()
    {
        return $"{AnswerId} - {AnswerText}";
    }
}