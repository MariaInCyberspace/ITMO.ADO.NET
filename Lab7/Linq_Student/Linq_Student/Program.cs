using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentQuery5 = from student in Student.students
                                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                where totalScore / 4 < student.Scores[0]
                                select student.Last + " " + student.First;
            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

    }
}
