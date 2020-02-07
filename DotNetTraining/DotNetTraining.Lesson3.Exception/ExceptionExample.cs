namespace DotNetTraining.Lesson3.Exception
{
	public class ExceptionExample
	{
		public void ReadFile(int index, string path)
		{
			var file = new System.IO.StreamReader(path);
			var buffer = new char[10];

			try
			{
				file.ReadBlock(buffer, index, buffer.Length);
			}
			catch (FileException ex) when (index > 0)
			{
				var message = $"Error reading from {path}. Message = {ex.Message}";
				//handle exception
			}
			finally
			{
				file.Close();
			}

			// Do something with buffer...
		}
	}
}
