namespace DotNetTraining.Lesson2.Classes.AccessModifiers
{
    public sealed class AccessExample
    {
        public AccessExample()
        {
            new BaseAccessModifiersExample();
            new BaseAccessModifiersExample.InternalClass();
            new BaseAccessModifiersExample.PublicClass();
        }
    }
}
