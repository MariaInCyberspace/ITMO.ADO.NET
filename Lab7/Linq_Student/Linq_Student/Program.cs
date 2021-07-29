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
            // Create and add another student to the list of students
            Student newStudent = new Student { First = "Alva", Last = "Garcia", ID = 114, Scores = new List<int> { 75, 98, 87, 79 } };
            Student.students.Add(newStudent);

            // Return a collection of summed up scores for each student
            var studentQuery_totalScore = from student in Student.students
                                            let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                            select totalScore;

            // Calculate the average of total student scores
            double averageScore = studentQuery_totalScore.Average();

            // Returns a collection of first names of students whose last names satisfy the search condition
            IEnumerable<string> studentQuery7 = from student in Student.students
                                                where student.Last == "Garcia"
                                                select student.First;

            // Returns a collection of anonymous types based on the search condition
            var studentQuery8 = from student in Student.students
                                let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                where x > averageScore
                                select new { id = student.ID, score = x };


            foreach (var item in studentQuery8)
            {
                Console.WriteLine("StudentID: {0}, Student Score: {1}", item.id, item.score);
            }


            Console.WriteLine("The Garcias in the class are: ");
            if (studentQuery7.Count() != 0)
            {
                foreach (string s in studentQuery7)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("There aren't any Garcias in this class");
            }
            
            Console.ReadLine();
        }

    }
}
