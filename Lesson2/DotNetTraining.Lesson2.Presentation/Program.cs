using System;
using System.Collections.Generic;
using DotNetTraining.Lesson2.Classes;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Base;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Generators;
using DotNetTraining.Lesson2.Partial;

namespace DotNetTraining.Lesson2.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void RunReportsExample()
        {
            var cars = new List<CarEntity>()
            {
                new CarEntity(),
                new CarEntity(),
                new CarEntity(),
                new CarEntity(),
                new CarEntity(),
            };
            var homes = new List<HomeEntity>()
            {
                new HomeEntity(),
                new HomeEntity(),
                new HomeEntity(),
                new HomeEntity(),
                new HomeEntity()
            };
            BaseReportGenerator<CarEntity> carReportGenerator = new CarReportGenerator();
            BaseReportGenerator<HomeEntity> homeReportGenerator = new HomeReportGenerator();

            Console.WriteLine(carReportGenerator.GenerateReport(cars));
            Console.WriteLine();
            Console.WriteLine(homeReportGenerator.GenerateReport(homes));
        }

        static void RunAnonimTypesExample()
        {
            var obj = new
            {
                Name = "CSharp",
                Age = 22
            };

            PrintObj("TEST-HEADER");

            void PrintObj(string header)
            {
                Console.WriteLine("Header: {0}", header);
                Console.WriteLine($"Name: {obj.Name}, Age: {obj.Age}");
                Console.WriteLine();
            }
        }

        static void RunFinalizerExample()
        {
            for (var i = 0; i < 10; i++)
            {
                new FinalizerExample();
            }

            GC.Collect(0);
        }

        static void RunPatternMatchingExample()
        {
            object obj = 1; 
            
            if (obj is int number)
            {
                Console.WriteLine(number.GetType().Name);
            }

            PrintType(1);
            PrintType(null);
            PrintType("string");
            PrintType(new Program());

            void PrintType(object ob)
            {
                switch (ob)
                {
                    case int numberSwitch:
                        Console.WriteLine("Switch: {0}", numberSwitch.GetType().Name);
                        break;
                    case null:
                        Console.WriteLine("Switch: NULL");
                        break;
                    case string stringSwitch:
                        Console.WriteLine("Switch: {0}", stringSwitch.GetType().Name);
                        break;
                    default: 
                        Console.WriteLine("Unknown type.");
                        break;
                }
            }
        }

        static void RunPartialExample()
        {
            new Bootstrap().Run();
        }
    }
}
