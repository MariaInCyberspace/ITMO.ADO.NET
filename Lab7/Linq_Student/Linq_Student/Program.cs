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
                                                where student.Scores[2] > 90
                                                select student;
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }
            Console.ReadLine();
        }

    }
}
