using System;
using System.Collections.Generic;

namespace DotNetTraining.Lesson1.LoopsAndArrays
{
    public class LoopsAndArraysExample
    {
	    public void PrintLoopsExample()
	    {
		    for (int i = 0; i < 5; i++)
		    {
			    Console.WriteLine(i);
		    }

		    int n = 0;
		    while (n < 5)
		    {
			    Console.WriteLine(n);
			    n++;
		    }

		    int x = 0;
		    do
		    {
			    Console.WriteLine(x);
			    x++;
		    } while (x < 5);

		    var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
		    int count = 0;
		    foreach (int element in fibNumbers)
		    {
			    count++;
			    Console.WriteLine($"Element #{count}: {element}");
		    }
		    Console.WriteLine($"Number of elements: {count}");
		}

	    public void PrintArraysExample()
	    {

	    }
    }
}
