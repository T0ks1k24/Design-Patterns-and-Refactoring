using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

class StudentManager
{
    private List<Student> students;

    public StudentManager(List<Student> students)
    {
        this.students = students;
    }

    public Student GetStudentById(int studentId)
    {
        foreach (var student in students)
        {
            if (student.Id == studentId)
                return student;
        }
        return null;
    }

}
