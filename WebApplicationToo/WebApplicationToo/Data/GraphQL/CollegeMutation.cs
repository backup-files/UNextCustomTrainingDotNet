using GraphQL;
using GraphQL.Types;
using WebApplicationToo.Data.Entities;
using WebApplicationToo.Data.GraphQL.Types;
using WebApplicationToo.Repositories;

namespace WebApplicationToo.Data.GraphQL {
    public class CollegeMutation: ObjectGraphType {
        public CollegeMutation(StudentRepository repository)
        {
            base.Field<StudentType> (
                "createStudent",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StudentInputType>> { Name = "name" }),
                resolve: context =>
                {
                    var student = context.GetArgument<Student>("name");
                    return repository.PostStudent(student);
                }
            );
        }
    }
}