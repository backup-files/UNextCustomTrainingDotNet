using System;
using GraphQL.Types;

namespace WebApplicationToo.Data.GraphQL {

    public class CollegeSchema: Schema {
        public CollegeSchema(IServiceProvider resolver): base(resolver)
        {
            Query = (IObjectGraphType) resolver.GetService(typeof(CollegeQuery));
        }
    }
}