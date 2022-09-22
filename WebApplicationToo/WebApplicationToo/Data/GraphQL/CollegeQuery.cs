using GraphQL.Types;
using WebApplicationToo.Data.GraphQL.Types;
using WebApplicationToo.Repositories;

namespace WebApplicationToo.Data.GraphQL {

    public class CollegeQuery: ObjectGraphType {
        public CollegeQuery(StudentRepository repository)
        {
            Field<ListGraphType<StudentType>>("students", resolve: context => repository.GetStudents());
        }
    }
}