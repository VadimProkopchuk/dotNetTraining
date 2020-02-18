using System.Threading;

namespace DotNetTraining.Lesson7.Thread
{
	public class ThreadSynchronizationExample
	{
		private static int _sharedVariable;

		private static readonly object Locker = new object();

		private static readonly Mutex MutexObj = new Mutex();

		private static readonly Semaphore Semaphore = new Semaphore(3, 3);

		private static readonly AutoResetEvent WaitHandler = new AutoResetEvent(true);

		public static void RunSynchronizationExample()
		{
			for (var i = 0; i < 5; i++)
			{
				var thread = new System.Threading.Thread(RunLockExample);

				thread.Start();
			}
		}

		private static void RunLockExample()
		{
			lock (Locker)
			{
				_sharedVariable = 1;
				_sharedVariable++;
			}
		}

		private static void RunMonitorExample()
		{
			var acquiredLock = false;

			try
			{
				Monitor.Enter(Locker, ref acquiredLock);

				_sharedVariable = 1;
				_sharedVariable++;
			}
			finally
			{
				if (acquiredLock)
				{
					Monitor.Exit(Locker);
				}
			}
		}

		private static void RunMutexExample()
		{
			MutexObj.WaitOne();

			_sharedVariable = 1;
			_sharedVariable++;

			MutexObj.ReleaseMutex();
		}

		private static void RunSemaphoreExample()
		{
			Semaphore.WaitOne();

			_sharedVariable = 1;
			_sharedVariable++;

			Semaphore.Release();
		}

		private static void RunAutoResetEventExample()
		{
			WaitHandler.WaitOne();

			_sharedVariable = 1;
			_sharedVariable++;

			WaitHandler.Set();
		}
	}
}
