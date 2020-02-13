using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace DotNetTraining.Lesson5.UsingAndDisposablePattern
{
	public class BaseDisposableClass : IDisposable
	{
		// Flag: Has Dispose already been called?
		private bool _disposed;
		// Instantiate a SafeHandle instance.
		private readonly SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);

		// Public implementation of Dispose pattern callable by consumers.
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Protected implementation of Dispose pattern.
		protected virtual void Dispose(bool disposing)
		{
			if (_disposed)
				return;

			if (disposing)
			{
				_handle.Dispose();
				// Free any other managed objects here.
			}

			// Free any unmanaged objects here.

			_disposed = true;
		}
	}
}
