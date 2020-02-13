namespace DotNetTraining.Lesson5.UsingAndDisposablePattern
{
	public class UsingStatementExample
	{
		public void RunUsingStatementExample()
		{
			using (var disposableClass = new DerivedDisposableClass())
			{
				// do some work
			}
		}

		public void RunExpandedUsingStatementExample()
		{
			var baseClass = new BaseDisposableClass();

			try
			{
				// do some work
			}
			finally
			{
				baseClass?.Dispose();
			}
		}
	}
}
