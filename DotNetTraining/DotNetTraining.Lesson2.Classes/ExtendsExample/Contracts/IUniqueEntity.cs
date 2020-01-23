namespace DotNetTraining.Lesson2.Classes.ExtendsExample.Contracts
{
    public interface IUniqueEntity<T> : IEntity
    {
        T Identifier { get; }
    }
}
