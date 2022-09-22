using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplicationToo.Data.Entities;
using WebApplicationToo.Repositories;

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

        private readonly StudentRepository _repository;

//        public StudentController()
//        {
//            _context = new CollegeDbContext(null);
//        }

        // dependency injection
        public StudentController(StudentRepository repository)
        {
            this._repository = repository;
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
            return this._repository.GetStudents();
        }

        [HttpGet("v2/{id}")]
        public Student GetStudentWith(int id)
        {
            return this._repository.GetStudentWith(id);
        }

        [HttpPost("v2")]
        public Student PostStudent(Student student)
        {
            return this._repository.PostStudent(student);
        }

        [HttpPut("v2/{id}")]
        public Student PutStudent(int id, Student student)
        {
            return this._repository.PutStudent(id, student);
        }

        [HttpPatch("v2/{id}")]
        public Student PatchStudent(int id, Student student)
        {
            return this._repository.PatchStudent(id, student);
        }

        [HttpDelete("v2/{id}")]
        public string DeleteStudent(int id)
        {
            return this._repository.DeleteStudent(id);
        }
    }
}
