using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1
{
    public class Display
    {
        public void DisplayStudent(string sentence, Student? s)
        {
            if (s == null) Console.Write("Not found student");
            else
            {
                Console.WriteLine(sentence);
                Console.WriteLine("First Name: " + s.FirstName);
                Console.WriteLine("Last Name: " + s.LastName);
                Console.WriteLine("Gender : " + (s.Gender ? "Male" : "Female"));
                Console.WriteLine("PhoneNumber : " + s.PhoneNumber);
                Console.WriteLine("Birthplace : " + s.Birthplace);
                Console.WriteLine("Age : " + s.Age);
                Console.WriteLine("IsGraduated : " + s.IsGraduated);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void DisplayListStudents(string sentence, List<Student> students)
        {
            if (students.Count == 0) Console.WriteLine("List is empty");
            int count = 0;
            Console.WriteLine(sentence);
            foreach (var s in students)
            {
                count++;
                Console.WriteLine(count + " First Name: " + s.FirstName);
                Console.WriteLine("Last Name: " + s.LastName);
                Console.WriteLine("Gender : " + s.Gender);
                Console.WriteLine("PhoneNumber : " + s.PhoneNumber);
                Console.WriteLine("Birthplace : " + s.Birthplace);
                Console.WriteLine("Age : " + s.Age);
                Console.WriteLine("IsGraduated : " + s.IsGraduated);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void DisplayStrings(string sentence, List<string> fullNames)
        {
            int count = 0;
            Console.WriteLine(sentence);
            foreach (var s in fullNames)
            {
                count++;
                Console.WriteLine(count + " " + s);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
