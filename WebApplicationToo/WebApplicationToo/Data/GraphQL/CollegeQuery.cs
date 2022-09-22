using GraphQL;
using GraphQL.Types;
using WebApplicationToo.Data.GraphQL.Types;
using WebApplicationToo.Repositories;

namespace WebApplicationToo.Data.GraphQL {

    public class CollegeQuery: ObjectGraphType {
        public CollegeQuery(StudentRepository repository)
        {
            Field<ListGraphType<StudentType>>("students", resolve: context => repository.GetStudents());
            Field<StudentType>("studentsById", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }), resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return repository.GetStudentWith(id);
                });
        }
    }
}