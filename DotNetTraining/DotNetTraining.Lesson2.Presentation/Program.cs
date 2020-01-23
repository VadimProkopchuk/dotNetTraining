using System;
using System.Collections.Generic;
using DotNetTraining.Lesson2.Classes;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Base;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Contracts;
using DotNetTraining.Lesson2.Classes.ExtendsExample.Generators;

namespace DotNetTraining.Lesson2.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportsExample();
        }

        static void ReportsExample()
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
   }
}
