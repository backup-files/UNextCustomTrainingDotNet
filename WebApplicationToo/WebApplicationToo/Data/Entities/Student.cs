using System.ComponentModel.DataAnnotations;

namespace WebApplicationToo.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}
