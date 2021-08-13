using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace DotNetTraining.Lesson5.UsingAndDisposablePattern
{
	public class DerivedDisposableClass : BaseDisposableClass
	{
		// Flag: Has Dispose already been called?
		private bool _disposed;
		// Instantiate a SafeHandle instance.
		private readonly SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);

		// Protected implementation of Dispose pattern.
		protected override void Dispose(bool disposing)
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
			// Call base class implementation.
			base.Dispose(disposing);
		}
	}
}
