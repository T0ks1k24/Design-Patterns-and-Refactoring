using System.Collections.Generic;

namespace Lab1;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> Grades { get; set; }
    public double CalculateAverageGrade()
    {
        return Grades.Average();
    }

    public void AddGrade(int grade)
    {
        Grades.Add(grade);
    }


    public static Student GetStudentInfo(int studentId, List<Student> students)
    {
        foreach (var student in students)
        {
            if (student.Id == studentId)
                return student;
        }
        return null;
    }

    public static void ProcessStudentData(List<Student> students)
    {
        foreach (var student in students)
        {
            double average_grade = student.CalculateAverageGrade();
            Console.WriteLine($"Student: {student.Name}, Average Grade: {average_grade:F2}");
        }
    }
}
