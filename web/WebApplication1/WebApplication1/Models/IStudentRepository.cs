using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);

        void AddStudent(Student student);

        IEnumerable<Student> GetStudents();

        Student UpdateStudent(Student updateStudent);

        Student DeleteStudent(int id);
    }
}