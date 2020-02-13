using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetTraining.Lesson6.LINQ.Samples
{
    public class LinqExamples
    {
        public List<LinqUser> GetUsersByName(string name)
        {
            return DataUsers.Users.Where(x => x.Name == name).ToList();
        }

        public int CountByName(string name)
        {
            return DataUsers.Users.Count(x => x.Name == name);
        }

        public Dictionary<string, int> GetSumGroupAgeForNames()
        {
            return DataUsers.Users
                .GroupBy(x => x.Name)
                .ToDictionary(x => x.Key, x => x.Sum(u => u.Age));
        }

        public bool HasAnyAlex()
        {
            return DataUsers.Users.Any(x => x.Name == "Alex");
        }

        public IEnumerable<LinqUser> GetOrderedByAgeAsc()
        {
            return DataUsers.Users.OrderBy(x => x.Age);
        }

        public List<string> GetUniqueNames()
        {
            return DataUsers.Users.Select(x => x.Name).Distinct().ToList();
        }

    }
}
