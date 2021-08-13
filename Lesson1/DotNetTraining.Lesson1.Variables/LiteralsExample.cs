using System;

namespace DotNetTraining.Lesson1.Variables
{
    public class LiteralsExample
    {
        public void PrintBooleanLiterals()
        {
            Console.WriteLine(true);
            Console.WriteLine(false);
        }

        public void PrintIntegerLiterals()
        {
            Console.WriteLine(-5);
            Console.WriteLine(5);
            Console.WriteLine(5000);
        }

        public void PrintIntegerBinaryFormLiterals()
        {
            Console.WriteLine(0b11);        // 3
            Console.WriteLine(0b1011);      // 11
            Console.WriteLine(0b100001);    // 33
        }

        public void PrintIntegerHexadecimalFormLiterals()
        {
            Console.WriteLine(0x0A);    // 10
            Console.WriteLine(0xFF);    // 255
            Console.WriteLine(0xA1);    // 161
        }

        public void PrintRealNumberLiterals()
        {
            Console.WriteLine(3.14);
            Console.WriteLine(100.001);
            Console.WriteLine(-0.38);
            Console.WriteLine(3.2e3);
            Console.WriteLine(1.2E-1);
        }

        public void PrintCharLiterals()
        {
            Console.WriteLine('2');
            Console.WriteLine('A');
            Console.WriteLine('T');
            Console.WriteLine('\n');
            Console.WriteLine('\t');
            Console.WriteLine('\x78');    // x
            Console.WriteLine('\x5A');    // Z
            Console.WriteLine('\u0420');    // Р
            Console.WriteLine('\u0421');    // С
        }

        public void PrintStringLiterals()
        {
            Console.WriteLine("hello");
            Console.WriteLine("lesson 1 \"introduction to .NET\"");
            Console.WriteLine("hello \nworld");
        }

        public void PrintNullLiterals()
        {
            Console.WriteLine((object) null);
        }
    }
}