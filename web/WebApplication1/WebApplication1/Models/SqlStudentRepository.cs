using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly AppDbContext dbContext;

        public SqlStudentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddStudent(Student student)
        {
            dbContext.students.Add(student);
            dbContext.SaveChanges();
        }

        public Student DeleteStudent(int id)
        {
            Student student = dbContext.students.Find(id);
            if (student != null)
            {
                dbContext.students.Remove(student);
                dbContext.SaveChanges();
                return student;
            }
            return null;
        }

        public Student GetStudent(int id)
        {
            return dbContext.students.Find(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return dbContext.students.ToList();
        }

        public Student UpdateStudent(Student updateStudent)
        {
            var stduents = dbContext.students.Attach(updateStudent);    // 标记修改值
            stduents.State = Microsoft.EntityFrameworkCore.EntityState.Modified;    // 状态标为修改
            dbContext.SaveChanges();
            return updateStudent;
        }
    }
}