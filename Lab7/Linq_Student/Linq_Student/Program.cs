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
            var studentQuery4 = from student in Student.students
                                group student by student.Last[0] into studentGroup
                                orderby studentGroup.Key
                                select studentGroup;

            foreach (var groupOfStudents in studentQuery4)
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
