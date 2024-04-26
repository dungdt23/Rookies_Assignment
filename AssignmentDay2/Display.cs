using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1
{
    public class Display
    {
        public void DisplayStudent(string? sentence, Student? s)
        {
            if (s == null) Console.Write("Not found student");
            else
            {
                string output = "";
                if (!string.IsNullOrEmpty(sentence)) Console.WriteLine(sentence);
                //Console.WriteLine(s.FirstName + " " + s.LastName);
                output += "Full Name: " + s.FirstName + " " + s.LastName;
                //Console.WriteLine("Gender : " + (s.Gender ? "Male" : "Female"));
                output += "| Gender : " + (s.Gender ? "Male" : "Female");
                //Console.WriteLine("PhoneNumber : " + s.PhoneNumber);
                output += "| PhoneNumber : " + s.PhoneNumber;
                string formattedDate = s.DOB.ToString("d");
                //Console.WriteLine("Birthdate : " + formattedDate);
                output += "| Birthdate : " + formattedDate;
                Console.WriteLine(output);
            }
        }
        public void DisplayListStudents(string sentence, List<Student> students)
        {
            if (students.Count == 0) Console.WriteLine("List is empty");
            Console.WriteLine(sentence);
            foreach (var s in students)
            {
                DisplayStudent(null, s);
            }
            InsertLineBreak(3);

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
            InsertLineBreak(3);
        }
        public void DisplayNumbers(string sentence, List<int> numbers)
        {
            Console.WriteLine(sentence);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + " ,");
                }
            }
        }
        public void InsertLineBreak(int num)
        {
            for (int i = 0; i < num; i++) Console.WriteLine();
        }

    }
}
