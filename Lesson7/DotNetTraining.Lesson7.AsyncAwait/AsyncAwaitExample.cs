using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetTraining.Lesson7.AsyncAwait
{
	public class AsyncAwaitExample
	{
		public static async Task RunAsyncAwaitExampleAsync()
		{
			var cts = new CancellationTokenSource();
			var token = cts.Token;
			var numberOne = await FactorialValueTaskAsync(10);
			var numberTwo = await FactorialAsync(5);

			FactorialWhenAllAsync();
		}

		private static int Factorial(int n)
		{
			if (n < 1)
			{
				throw new Exception("Exception message");
			}

			var result = 1;

			for (var i = 1; i <= n; i++)
			{
				result *= i;
			}

			return result;
		}

		private static async Task<int> FactorialAsync(int n)
		{
			return await Task.Run(() => Factorial(n));
		}

		private static async void FactorialWhenAllAsync()
		{
			try
			{
				Task taskOne = Task.Run(() => Factorial(4));
				Task taskTwo = Task.Run(() => Factorial(3));
				Task taskThree = Task.Run(() => Factorial(5));

				await Task.WhenAll(taskOne, taskTwo, taskThree);

			}
			catch (Exception ex)
			{
				//handle ex
			}

		}

		private static async ValueTask<int> FactorialValueTaskAsync(int n)
		{
			return await Task.Run(() => Factorial(n));
		}
	}
}
