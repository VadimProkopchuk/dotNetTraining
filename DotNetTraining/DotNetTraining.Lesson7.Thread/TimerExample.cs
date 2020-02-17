using System.Threading;

namespace DotNetTraining.Lesson7.Thread
{
	public class TimerExample
	{
		public static void RunTimerExample()
		{
			var number = 0;
			var timerCallback = new TimerCallback(SomeMethod);
			var timer = new Timer(timerCallback, number, 0, 2000);
		}

		private static void SomeMethod(object obj)
		{
			//do some work
		}
	}
}
