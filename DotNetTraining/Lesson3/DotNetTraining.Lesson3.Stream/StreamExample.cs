using System.IO;
using System.Threading.Tasks;

namespace DotNetTraining.Lesson3.Stream
{
	public class StreamExample
	{
		public void WriteToFile(string path, string text)
		{
			using (var sw = new StreamWriter(path, false, System.Text.Encoding.Default))
			{
				sw.WriteLine(text);
			}
		}

		public async Task WriteToFileAsync(string path, string text)
		{
			using (var sw = new StreamWriter(path, false, System.Text.Encoding.Default))
			{
				await sw.WriteLineAsync(text);
			}
		}

		public string ReadFromFile(string path)
		{
			using (var sr = new StreamReader(path))
			{
				return sr.ReadToEnd();
			}
		}

		public async Task<string> ReadFromFileAsync(string path)
		{
			using (var sr = new StreamReader(path))
			{
				return await sr.ReadToEndAsync();
			}
		}
	}
}
