using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
            new Student {Name = "A", Id = 5},
            new Student {Name = "B", Id = 4},
            new Student {Name = "C", Id = 3},
            new Student {Name = "D", Id = 2},
            new Student {Name = "E", Id = 1},
        };

        private readonly CollegeDbContext _context;
        public StudentController(CollegeDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        [HttpGet("v2")]
        public IQueryable<Student> GetStudents()
        {
            return _context.Set<Student>();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _students.First(e => e.Id == id);
        }

        [HttpGet("v2/{id}")]
        public Student GetStudentWith(int id)
        {
            return _context.Set<Student>().First(e => e.Id == id);
        }

        [HttpPost]
        public Student Post(Student student)
        {
            this._students.Add(student);
            return this._students[^1];
        }

        [HttpPost("v2")]
        public Student PostStudent(Student student)
        {
            this._context.Students.Add(student);
            return this._context.Students.Last(s => s.Id == student.Id);
        }

        [HttpPut("{id}")]
        public Student Put(int id, Student student)
        {
            var index = _students.IndexOf(_students.First(s => s.Id == id));
            _students[index] = student;
            return _students[index];
        }

        [HttpPut("v2/{id}")]
        public Student Put
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
    }
}
