using System;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Contracts;

namespace DotNetTraining.Lesson2.Classes.ExtendsExample.Base
{
    public abstract class BaseUniqueEntity : IUniqueEntity<Guid>
    {
        protected BaseUniqueEntity(string entityName)
        {
            EntityName = entityName;
            Identifier = Guid.NewGuid();
        }

        public Guid Identifier { get; }

        public string EntityName { get; }
    }
}
