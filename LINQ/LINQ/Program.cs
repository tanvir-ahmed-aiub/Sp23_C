using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void PrintList(List<Student> students) { 
            foreach(var s in students)
            {

                s.Show();
            }
        }
        static void Main(string[] args)
        {
            int[] marks = new int[] {45,65,12,56,78,89,88,86,85 };
            /*int[] aplus = new int[marks.Length];
            int count=0;
            foreach (var item in marks)
            {
                if (item >= 80) aplus[count++] = item;
            }*/
            var apuls = (from item in marks
             where item >= 80
             select item).ToArray();
            List<Student> students  = new List<Student>();
            Random rand = new Random();
            for (int i = 1; i <= 100; i++) {
                students.Add(new Student() {
                    Id = i,
                    Name = "Student "+ i,
                    Marks = rand.Next(10,100)
                });
            }
            PrintList(students);
            var scstudents = (from s in students
                             where s.Marks>=85
                             select s).ToList();
            Console.WriteLine("--------Scholarships "+scstudents.Count+"---------");
            PrintList(scstudents);
            var sc110= (from s in students
                        where s.Marks >=85 && s.Id<=10
                        select s).ToList();
            Console.WriteLine("--------Scholarships++ " + sc110.Count + "---------");
            PrintList(sc110);

        }
    }
}
