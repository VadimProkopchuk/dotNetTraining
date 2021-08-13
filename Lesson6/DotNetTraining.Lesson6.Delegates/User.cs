namespace DotNetTraining.Lesson6.Delegates
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void PrintInfo(Print print)
        {
            print($"User with name {Name}");
        }
    }
}
