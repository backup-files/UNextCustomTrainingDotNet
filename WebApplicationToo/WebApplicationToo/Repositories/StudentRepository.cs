using System.Collections.Generic;
using WebApplicationToo.Data;
using WebApplicationToo.Data.Entities;
using System.Linq;

namespace WebApplicationToo.Repositories {

    public class StudentRepository {

        private readonly CollegeDbContext _context;

        public StudentRepository(CollegeDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Students;
        }

        public Student GetStudentWith(int id)
        {
            return _context.Students.First(e => e.Id == id);
        }

        public Student PostStudent(Student student)
        {
            this._context.Students.Add(student);
            this._context.SaveChanges();
            return this._context.Students.First(s => s.Name == student.Name);
        }

        public Student PutStudent(int id, Student student)
        {
            var studentToUpdate = this._context.Students.First(s => (s.Id == id));
            studentToUpdate.Name = student.Name;
            this._context.SaveChanges();
            return this._context.Students.First(s => s.Id == id);
        }

        public Student PatchStudent(int id, Student student)
        {
            var studentToPatch = this._context.Students.First(s => (s.Id == id));
            studentToPatch.Name = student.Name;
            this._context.SaveChanges();
            return this._context.Students.First(s => s.Id == id);
        }

        public string DeleteStudent(int id)
        {
            this._context.Students.Remove(this._context.Students.First(s => s.Id == id));
            this._context.SaveChanges();
            return "Deleted.";
        }
    }
}