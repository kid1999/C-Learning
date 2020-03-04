using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class MockStudent : IStudentRepository
    {
        private List<Student> _students;

        public MockStudent()
        {
            _students = new List<Student>()
            {
                new Student(){Id=1,Name="kid",ClassName="cs171",Email="dsad"},
                new Student(){Id=2,Name="kid2",ClassName="cs17s1",Email="dssdadad"},
                new Student(){Id=3,Name="kid3",ClassName="cs17da1",Email="dd"}
            };
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public Student DeleteStudent(int id)
        {
            return null;
        }

        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        public Student UpdateStudent(Student student)
        {
            return null;
        }
    }
}