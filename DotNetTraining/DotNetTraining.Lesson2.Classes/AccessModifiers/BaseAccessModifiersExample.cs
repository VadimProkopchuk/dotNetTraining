namespace DotNetTraining.Lesson2.Classes.AccessModifiers
{
    public class BaseAccessModifiersExample
    {
        public BaseAccessModifiersExample()
        {
            new PrivateClass();
        }

        private class PrivateClass { }

        internal class InternalClass { }

        public class PublicClass { }

        protected class ProtectedClass { }
    }
}
