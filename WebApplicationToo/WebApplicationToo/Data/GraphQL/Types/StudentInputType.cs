using GraphQL.Types;

namespace WebApplicationToo.Data.GraphQL.Types
{
    public class StudentInputType: InputObjectGraphType
    {
        public StudentInputType()
        {
            Name = "studentInput";
            base.Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}