namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student> 
        {
            new Student { Id = 1, Name = "Alice", Grades = new List<int> { 85, 92, 78, 90 } },
            new Student { Id = 2, Name = "Bob", Grades = new List<int> { 76, 88, 95, 82 } },
            new Student { Id = 3, Name = "Charlie", Grades = new List<int> { 90, 85, 88, 92 } }
        };

        Student.ProcessStudentData(students);

        StudentManager studentManager = new StudentManager(students);
        Student student = studentManager.GetStudentById(2);
        if (student != null) {
            student.AddGrade(98);
            Console.WriteLine($"New grade added for {student.Name}. Average Grade: {student.CalculateAverageGrade():F2}");
        }

        Console.ReadLine();
    }
}

