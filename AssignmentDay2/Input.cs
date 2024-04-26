using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1
{
    public class Input
    {
        public List<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>();
            Student student1 = new Student
            {
                FirstName = "Hoa",
                LastName = "Truong",
                Gender = true,
                DOB = new DateTime(2002, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Vinh Phuc",
                Age = 22,
                IsGraduated = false,
            };
            Student student2 = new Student
            {
                FirstName = "Anh",
                LastName = "Nguyen",
                Gender = true,
                DOB = new DateTime(2000, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Ha Noi",
                Age = 24,
                IsGraduated = true,
            };
            Student student3 = new Student
            {
                FirstName = "Minh",
                LastName = "Hoang",
                Gender = true,
                DOB = new DateTime(2001, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Ha Noi",
                Age = 23,
                IsGraduated = true,
            };
            Student student4 = new Student
            {
                FirstName = "Hieu",
                LastName = "Mai",
                Gender = true,
                DOB = new DateTime(2002, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Ha Noi",
                Age = 22,
                IsGraduated = false,
            };
            Student student5 = new Student
            {
                FirstName = "Vu",
                LastName = "La",
                Gender = true,
                DOB = new DateTime(1999, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Ha Noi",
                Age = 25,
                IsGraduated = true,
            };
            Student student6 = new Student
            {
                FirstName = "Phuong",
                LastName = "Nguyen",
                Gender = true,
                DOB = new DateTime(2002, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Sai Gon",
                Age = 22,
                IsGraduated = false,
            };
            Student student7 = new Student
            {
                FirstName = "Quang",
                LastName = "Nguyen",
                Gender = true,
                DOB = new DateTime(2002, 1, 1),
                PhoneNumber = "0983327119",
                Birthplace = "Phu Tho",
                Age = 22,
                IsGraduated = false,
            };
            Student student8 = new Student
            {
                FirstName = "Hoang",
                LastName = "Le",
                Gender = true,
                DOB = new DateTime(2001, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Ha Noi",
                Age = 23,
                IsGraduated = true,
            };
            Student student9 = new Student
            {
                FirstName = "Manh",
                LastName = "Phan",
                Gender = true,
                DOB = new DateTime(2000, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Ha Noi",
                Age = 24,
                IsGraduated = true,
            };
            Student student10 = new Student
            {
                FirstName = "Hoang",
                LastName = "Thai",
                Gender = true,
                DOB = new DateTime(1997, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Hai Phong",
                Age = 27,
                IsGraduated = false,
            };
            Student student11 = new Student
            {
                FirstName = "Nguyen",
                LastName = "Mai",
                Gender = false,
                DOB = new DateTime(1997, 11, 11),
                PhoneNumber = "0983327119",
                Birthplace = "Hai Phong",
                Age = 27,
                IsGraduated = false,
            };
            result.Add(student1);
            result.Add(student2);
            result.Add(student3);
            result.Add(student4);
            result.Add(student5);
            result.Add(student6);
            result.Add(student7);
            result.Add(student8);
            result.Add(student9);
            result.Add(student10);
            result.Add(student11);
            return result;
        }

    }
}
