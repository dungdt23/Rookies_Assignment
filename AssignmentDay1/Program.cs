using AssignmentDay1;
using System.Text.RegularExpressions;

public class Program
{
    public static List<Student> GetMaleStudents(List<Student> students)
    {
        List<Student> maleStudents = new List<Student>();
        //loop from first to last student in input student list
        foreach (Student student in students)
        {
            if (student.Gender) maleStudents.Add(student);
        }
        return maleStudents;
    }
    public static Student GetOldestStudent(List<Student> students)
    {
        Student oldestStudent = students[0];
        int indexOldest = 0;
        //loop from first to last student in input student list
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].DOB < oldestStudent.DOB)
            {
                oldestStudent = students[i];
                indexOldest = i;
            }
        }
        for (int i = 0; i < students.Count; i++)
        {
            //check if exist someone is same date of birth with oldest
            if (students[i].DOB == oldestStudent.DOB)
            {
                //check if index is before oldest
                if (i < indexOldest)
                {
                    indexOldest = i;
                }
            }
        }
        return students[indexOldest];
    }
    public static List<string> GetFullNames(List<Student> students)
    {
        List<string> fullNames = new List<string>();
        foreach (var s in students)
        {
            string fullName = s.LastName + " " + s.FirstName;
            fullNames.Add(fullName);
        }
        return fullNames;
    }
    public static List<Student> GetStudentsBaseOnAge(List<Student> students, int condition)
    {
        List<Student> results = new List<Student>();
        foreach (Student s in students)
        {
            switch (condition)
            {
                //greater than 2000
                case 1:
                    if (s.DOB.Year > 2000) results.Add(s);

                    break;
                //equal to 2000
                case 0:

                    if (s.DOB.Year == 2000) results.Add(s);

                    break;
                // less than 2000
                case -1:

                    if (s.DOB.Year < 2000) results.Add(s);

                    break;
            }
        }
        return results;
    }
    public static Student? GetFirstHaNoiStudents(List<Student> students)
    {
        int count = 0;
        while (true)
        {
            Student student = students[count];
            string formatedPlace = Regex.Replace(student.Birthplace, @"\s", "");
            if (formatedPlace.Equals("hanoi", StringComparison.OrdinalIgnoreCase))
            {
                return student;
            }
            else count++;
            if (count == students.Count) break;
        }
        return null;
    }
    static void Main(string[] args)
    {
        //using for display text and result
        Display display = new Display();

        //using for get data student
        Input input = new Input();
        List<Student> students = input.GetAllStudents();

        //1. Return a list of members who is male
        display.DisplayListStudents("TASK1. List of members who is Male: ", GetMaleStudents(students));

        //2. Return the oldest 
        display.DisplayStudent("TASK2. The oldest student is : ", GetOldestStudent(students));

        //3. Return list contains only full name
        display.DisplayStrings("TASK3. List Full Name is :", GetFullNames(students));

        //4. Return 3 list of members who has birth year is 2000, greater than 2000, less than 2000
        //variable to express condition of students birth years
        int equal = 0; int greater = 1; int less = -1;
        display.DisplayListStudents("TASK4. List of members who has birth year is 2000 :", GetStudentsBaseOnAge(students, equal));
        display.DisplayListStudents("TASK4. List of members who has birth year is greater than 2000 :", GetStudentsBaseOnAge(students, greater));
        display.DisplayListStudents("TASK4. List of members who has birth year is less than 2000 ", GetStudentsBaseOnAge(students, less));

        //5. Return first person who was born in Ha Noi
        display.DisplayStudent("TASK5. First person who was born in Ha Noi is: ", GetFirstHaNoiStudents(students));

    }
}
