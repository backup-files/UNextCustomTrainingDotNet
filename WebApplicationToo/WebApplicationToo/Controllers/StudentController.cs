using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using WebApplicationToo.Data;
using WebApplicationToo.Data.Entities;

namespace WebApplicationToo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly List<Student> _students = new List<Student>
        {
            new Student {Name = "Aaaaaaaaaaa", Id = 5},
            new Student {Name = "Bbbbbbbbbbb", Id = 4},
            new Student {Name = "Ccccccccccc", Id = 3},
            new Student {Name = "Ddddddddddd", Id = 2},
            new Student {Name = "Eeeeeeeeeee", Id = 1},
        };

        private readonly CollegeDbContext _context;

//        public StudentController()
//        {
//            _context = new CollegeDbContext(null);
//        }

        // dependency injection
        public StudentController(CollegeDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _students.First(e => e.Id == id);
        }

        [HttpPost]
        public Student Post(Student student)
        {
            this._students.Add(student);
            return this._students[^1];
        }

        [HttpPut("{id}")]
        public Student Put(int id, Student student)
        {
            var index = _students.IndexOf(_students.First(s => s.Id == id));
            _students[index] = student;
            return _students[index];
        }

        [HttpPatch("{id}")]
        public Student Patch(int id, Student student)
        {
            var index = _students.IndexOf(_students.First(s => s.Id == id));
            _students[index].Name = student.Name;
            return _students[index];
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            int index = _students.IndexOf(_students.First(s => s.Id == id));
            _students.RemoveAt(index);
            return "Deleted.";
        }

        [HttpGet("v2")]
        public IEnumerable<Student> GetStudents()
        {
            return _context.Students;
        }

        [HttpGet("v2/{id}")]
        public Student GetStudentWith(int id)
        {
            return _context.Students.First(e => e.Id == id);
        }

        [HttpPost("v2")]
        public Student PostStudent(Student student)
        {
            this._context.Students.Add(student);
            this._context.SaveChanges();
            return this._context.Students.First(s => s.Name == student.Name);
        }

        [HttpPut("v2/{id}")]
        public Student PutStudent(int id, Student student)
        {
            var studentToUpdate = this._context.Students.First(s => (s.Id == id));
//            studentToUpdate.Entity.Id = student.Id;
            studentToUpdate.Name = student.Name;
            this._context.SaveChanges();
            return this._context.Students.First(s => s.Id == id);
        }

        [HttpPatch("v2/{id}")]
        public Student PatchStudent(int id, Student student)
        {
            var studentToPatch = this._context.Students.First(s => (s.Id == id));
            studentToPatch.Name = student.Name;
            this._context.SaveChanges();
            return this._context.Students.First(s => s.Id == id);
        }

        [HttpDelete("v2/{id}")]
        public string DeleteStudent(int id)
        {
            this._context.Students.Remove(this._context.Students.First(s => s.Id == id));
            this._context.SaveChanges();
            return "Deleted.";
        }
    }
}
