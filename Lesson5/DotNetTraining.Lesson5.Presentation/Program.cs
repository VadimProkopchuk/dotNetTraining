using DotNetTraining.Lesson5.PointersAndUnsafe;
using System;

namespace DotNetTraining.Lesson5.Presentation
{
	class Program
	{
		private const long MaxGarbage = 1000;

		static unsafe void Main(string[] args)
		{
			var i = 5;

			PointersExample.SquarePtrParam(&i);
			Console.WriteLine(i);

			Program programClass = new Program();

			// Determine the maximum number of generations the system
			// garbage collector currently supports.
			Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);

			programClass.MakeSomeGarbage();

			// Determine which generation myGCCol object is stored in.
			Console.WriteLine("Generation: {0}", GC.GetGeneration(programClass));

			// Determine the best available approximation of the number 
			// of bytes currently allocated in managed memory.
			Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

			// Perform a collection of generation 0 only.
			GC.Collect(0);

			// Determine which generation myGCCol object is stored in.
			Console.WriteLine("Generation: {0}", GC.GetGeneration(programClass));

			Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

			// Perform a collection of all generations up to and including 2.
			GC.Collect(2);

			// Determine which generation myGCCol object is stored in.
			Console.WriteLine("Generation: {0}", GC.GetGeneration(programClass));
			Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
			Console.Read();
		}

		private void MakeSomeGarbage()
		{
			for (int i = 0; i < MaxGarbage; i++)
			{
				var version = new Version();
			}
		}
	}
}
