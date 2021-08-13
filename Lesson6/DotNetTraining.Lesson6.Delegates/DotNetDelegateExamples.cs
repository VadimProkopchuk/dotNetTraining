using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetTraining.Lesson6.Delegates
{
    public class DotNetDelegateExamples
    {
        private List<int> _values;

        public DotNetDelegateExamples(List<int> values)
        {
            _values = values;
        }

        public List<int> FilterBadPractice(Predicate<int> filterExpression)
        {
            var filteredValues = new List<int>();

            foreach (var value in _values)
            {
                if (filterExpression(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }

        #region Best Practice 

        public IEnumerable<int> Filter(Predicate<int> filterExpression) => _values.Where(x => filterExpression(x));

        public IEnumerable<int> Filter(Func<int, bool> filterExpression) => _values.Where(filterExpression);

        #endregion
    }
}
