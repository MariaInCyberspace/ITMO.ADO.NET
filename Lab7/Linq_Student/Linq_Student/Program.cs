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
            var studentQuery6 = from student in Student.students
                                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                select totalScore;

            Console.WriteLine("Class average is: {0}", studentQuery6.Average());
            Console.ReadLine();
        }

    }
}
