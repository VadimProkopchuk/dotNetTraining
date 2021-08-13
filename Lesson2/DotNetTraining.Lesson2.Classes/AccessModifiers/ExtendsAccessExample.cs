namespace DotNetTraining.Lesson2.Classes.AccessModifiers
{
    public sealed class ExtendsAccessExample : BaseAccessModifiersExample
    {
        public ExtendsAccessExample()
        {
            new BaseAccessModifiersExample();
            new BaseAccessModifiersExample.InternalClass();
            new BaseAccessModifiersExample.ProtectedClass();
            new BaseAccessModifiersExample.PublicClass();
        }
    }
}
