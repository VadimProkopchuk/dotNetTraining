namespace DotNetTraining.Lesson8.ORM.Models.Contracts
{
    public interface IAppEntity<T>
    {
        T Id { get; set; }
    }
}
