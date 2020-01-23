using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Contracts;

namespace DotNetTraining.Lesson2.Classes.ExtendsExample.Base
{
    public abstract class BaseReportGenerator<T> where T : IUniqueEntity<Guid>
    {
        public string GenerateReport(IEnumerable<T> entities)
        {
            var stringBuilder = new StringBuilder();
            AppendHeader(stringBuilder);
            
            if (entities != null)
            {
                foreach (var entity in entities.Where(IsValid))
                {
                    stringBuilder.AppendLine($"{entity.EntityName}-Id: {entity.Identifier}");
                }
            }

            return stringBuilder.ToString();
        }

        protected abstract bool IsValid(T entity);
        protected abstract string ReportGeneratorName { get; }

        protected virtual StringBuilder AppendHeader(StringBuilder builder)
        {
            builder.AppendLine($"Report Generator Name: {ReportGeneratorName}");
            return builder;
        }
    }
}
