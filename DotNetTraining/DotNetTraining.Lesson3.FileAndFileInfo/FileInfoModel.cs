using System;
using System.IO;

namespace DotNetTraining.Lesson3.FileAndFileInfo
{
	public class FileInfoModel
	{
		public string Name { get; set; }

		public long Length { get; set; }

		public DateTime CreationTime { get; set; }

		public void Map(FileInfo src)
		{
			Name = src.Name;
			Length = src.Length;
			CreationTime = src.CreationTime;
		}
	}
}
