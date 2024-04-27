using AssignmentDay1;
using AssignmentDay2;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Program
{
    public static List<Student> GetMaleStudents(List<Student> students)
    {
        List<Student> maleStudents = students.Where(student => student.Gender == true).ToList();
        return maleStudents;
    }
    public static Student? GetOldestStudent(List<Student> students)
    {
        if (students.Count == 0) return null;
        Student oldestStudent = students.OrderBy(student => student.DOB).FirstOrDefault();
        return oldestStudent;
    }
    public static List<string> GetFullNames(List<Student> students)
    {
        List<string> fullNames = students.Select(x => x.LastName + " " + x.FirstName).ToList();
        return fullNames;
    }
    public static List<Student> GetStudentsBaseOnAge(List<Student> students, Func<Student, bool> conditon)
    {
        return students.Where(conditon).ToList();
    }
    public static Student? GetFirstHaNoiStudents(List<Student> students)
    {
        Student? student = students.FirstOrDefault(
            x => Regex.Replace(x.Birthplace, @"\s", "").ToLower().Equals("hanoi"));
        return student;
    }
    static async Task Main(string[] args)
    {
        //using for display text and result
        Display display = new Display();

        //using for get data student
        Input input = new Input();
        List<Student> students = input.GetAllStudents();

        //TASK 1. Return a list of members who is male
        display.DisplayListStudents("TASK 1: List of members who is Male: ", GetMaleStudents(students));



        //TASK 2. Return the oldest 
        display.DisplayStudent("TASK 2: The oldest student is : ", GetOldestStudent(students)); 
        display.InsertLineBreak(3);




        //TASK 3. Return list contains only full name
        display.DisplayStrings("TASK 3: List Full Name is :", GetFullNames(students));



        //TASK 4. Return 3 list of members who has birth year is 2000, greater than 2000, less than 2000
        //variable to express condition of students birth years
        Func<Student, bool> equalCondition = s => s.DOB.Year == 2000;
        Func<Student, bool> greaterCondition = s => s.DOB.Year > 2000;
        Func<Student, bool> lessCondition = s => s.DOB.Year < 2000;
        display.DisplayListStudents("TASK 4.1 : List of members who has birth year is 2000 :", GetStudentsBaseOnAge(students, equalCondition));
        display.DisplayListStudents("TASK 4.2 : List of members who has birth year is greater than 2000 :", GetStudentsBaseOnAge(students, greaterCondition));
        display.DisplayListStudents("TASK 4.3 : List of members who has birth year is less than 2000 ", GetStudentsBaseOnAge(students, lessCondition));




        //TASK 5. Return first person who was born in Ha Noi
        display.DisplayStudent("TASK5 : First person who was born in Ha Noi is: ", GetFirstHaNoiStudents(students));
        display.InsertLineBreak(3);




        //TASK 6. Return prime numbers from 0 to 100
        PrimeNumber primeNumber = new PrimeNumber();
        bool isDelay = true;
        //example for sync find prime numbers
        var syncWatch = new Stopwatch();
        syncWatch.Start();
        List<int> syncPrimeNumbers = await primeNumber.GetPrimeNumbers(0, 100, !isDelay);
        Console.WriteLine("TASK 6.1: Synchronized find prime number cost " + syncWatch.Elapsed);
        display.DisplayNumbers("TASK 6.1: Get Sync Prime Numbers List :", syncPrimeNumbers);
        display.InsertLineBreak(3);



        //example for async find prime numbers
        var asyncWatch = new Stopwatch();
        asyncWatch.Start();
        var asyncPrimeNumbers1 = primeNumber.GetPrimeNumbers(0, 25, !isDelay);
        var asyncPrimeNumbers2 = primeNumber.GetPrimeNumbers(26, 50, !isDelay);
        var asyncPrimeNumbers3 = primeNumber.GetPrimeNumbers(51, 75, !isDelay);
        var asyncPrimeNumbers4 = primeNumber.GetPrimeNumbers(76, 100, !isDelay);
        await Task.WhenAll(asyncPrimeNumbers1, asyncPrimeNumbers2, asyncPrimeNumbers3, asyncPrimeNumbers4);
        Console.WriteLine("TASK 6.2: Asynchronized find prime number cost " + asyncWatch.Elapsed);
        List<int> primeNumbers1 = asyncPrimeNumbers1.Result;
        List<int> primeNumbers2 = asyncPrimeNumbers2.Result;
        List<int> primeNumbers3 = asyncPrimeNumbers3.Result;
        List<int> primeNumbers4 = asyncPrimeNumbers4.Result;
        List<int> combinedResultPrimeNumbers = new List<int>();
        combinedResultPrimeNumbers.AddRange(primeNumbers1);
        combinedResultPrimeNumbers.AddRange(primeNumbers2);
        combinedResultPrimeNumbers.AddRange(primeNumbers3);
        combinedResultPrimeNumbers.AddRange(primeNumbers4);
        display.DisplayNumbers("TASK 6.2: Get Async Prime Numbers List :", combinedResultPrimeNumbers);
        display.InsertLineBreak(3);


        //example for delay 5 seconds find prime numbers
        Console.WriteLine("TASK 6.3: Process of find prime numbers will delay 5 seconds...");
        List<int> delayPrimeNumbers = await primeNumber.GetPrimeNumbers(0, 100, isDelay);
        display.DisplayNumbers("TASK 6.3: Get Delayed Prime Numbers List :", delayPrimeNumbers);

    }
}
