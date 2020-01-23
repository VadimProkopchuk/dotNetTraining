namespace DotNetTraining.Lesson2.Classes
{
    public class MethodOverloadExample
    {
        public string Example(string x)
        {
            return x.GetType().Name;
        }

        public string Example(int x)
        {
            return x.GetType().Name;
        }
    }
}
