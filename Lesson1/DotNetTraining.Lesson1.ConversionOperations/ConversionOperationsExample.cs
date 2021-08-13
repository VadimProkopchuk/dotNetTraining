namespace DotNetTraining.Lesson1.ConversionOperations
{
    public class ConversionOperationsExample
    {
        public void ImplicitConversionExample()
        {
            // Implicit conversion. A long can
            // hold any value an int can hold, and more!
            int num = 2147483647;
            long bigNum = num;
        }

        public void ExplicitConversionExample()
        {
            double x = 1234.7;
            int a;
            // Cast double to int.
            a = (int)x;
        }

        public void BoxingExample()
        {
            int i = 123;
            // The following line boxes i.
            object o = i;
        }

        public void UnboxingExample()
        {
            object o = 123;
            int i = (int)o;  // unboxing
        }
    }
}