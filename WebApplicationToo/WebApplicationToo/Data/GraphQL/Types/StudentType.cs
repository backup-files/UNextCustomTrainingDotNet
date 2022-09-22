using GraphQL.Types;
using WebApplicationToo.Data.Entities;

namespace WebApplicationToo.Data.GraphQL.Types {

    public class StudentType: ObjectGraphType<Student> {
        public StudentType()
        {
            base.Field(t => t.Id);
            base.Field(t => t.Name);
        }
    }
}