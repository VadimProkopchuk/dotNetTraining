using System;

namespace DotNetTraining.Lesson1.ConditionalExpressions
{
    public class ConditionalExpressionsAndStatementsExample
    {
        public void PrintRelationalOperatorsExample()
        {
            var a = 20;
            var b = 10;

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else
            {
                Console.WriteLine("a is not equal to b");
            }

            Console.WriteLine(a > b ? "a is greater than b" : "a is not greater that b");
        }

        public void PrintLogicalOperatorsExample()
        {
            var a = true;
            var b = true;

            if (a && b)
            {
                Console.WriteLine("condition is true");
            }
            if (a || b)
            {
                Console.WriteLine("condition is true");
            }

            a = false;

            if (!(a && b))
            {
                Console.WriteLine("condition is true");
            }
        }

        public void SwitchCaseExample()
        {
            object caseSwitch = 1;
            bool b = true;

            switch (caseSwitch)
            {
                case 1 when b:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case bool caseSwitchBool:
                    Console.WriteLine("Type case");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}