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
            IEnumerable<Student> studentQuery = from student in Student.students
                                                where student.Scores[0] > 90 && student.Scores[3] < 80
                                                orderby student.Last descending
                                                select student;
            var studentQuery2 = from student in Student.students
                                group student by student.Last[0];
            var studentQuery3 = from student in Student.students
                                group student by student.Last[0];
            foreach (var groupOfStudents in studentQuery3)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine(" {0} {1}", student.Last, student.First);
                }
            }
            Console.ReadLine();
        }

    }
}
