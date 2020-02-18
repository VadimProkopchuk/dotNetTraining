using System.Threading;

namespace DotNetTraining.Lesson7.Thread
{
	public class ThreadExample
	{
		public static void RunThreadExample()
		{
			var thread = System.Threading.Thread.CurrentThread;

			var threadName = thread.Name;
			var threadIsAlive = thread.IsAlive;
			var threadPriority = thread.Priority;
			var threadState = thread.ThreadState;
			var domain = System.Threading.Thread.GetDomain().FriendlyName;
		}

		public static void RunThreadStartExample()
		{
			var thread = new System.Threading.Thread(new ThreadStart(SomeMethod));

			thread.Start();

			//do some work
		}

		public static void RunParametrizedThreadStartExample()
		{
			var obj = new object();
			var thread = new System.Threading.Thread(new ParameterizedThreadStart(SomeMethod));

			thread.Start(obj);

			//do some work
		}

		private static void SomeMethod()
		{
			//do some work
		}

		private static void SomeMethod(object obj)
		{
			//do some work
		}
	}
}
