using static System.Console;
using static System.Math;
using Alias = System.Console;

namespace DotNetTraining.Lesson1.NamespacesAndStaticImport
{

    public class NamespacesAndStaticImportExample
    {
        public void PrintNamespacesAndStaticImportExample()
        {
            WriteLine(Sqrt(3 * 3 + 4 * 4));
            Alias.WriteLine(Sqrt(3 * 3 + 4 * 4));
        }
    }
}