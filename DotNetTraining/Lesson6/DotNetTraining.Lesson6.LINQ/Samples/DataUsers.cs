using System.Collections.Generic;

namespace DotNetTraining.Lesson6.LINQ.Samples
{
    public static class DataUsers
    {
        public static IEnumerable<LinqUser> Users = new List<LinqUser>()
        {
            new LinqUser(5, "Steve"),
            new LinqUser(52, "Alex"),
            new LinqUser(14, "Vadim"),
            new LinqUser(65, "Ivan"),
            new LinqUser(6, "John"),
            new LinqUser(9, "Julia"),
            new LinqUser(12, "Alex"),
            new LinqUser(23, "Ivan"),
            new LinqUser(31, "Alex"),
            new LinqUser(31, "Frank"),
        };
    }
}
