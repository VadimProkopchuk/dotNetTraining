using System.IO;

namespace DotNetTraining.Lesson3.FileAndFileInfo
{
	public class FileAndFileInfoExample
	{
		public FileInfoModel GetFileInfo(string path)
		{
			var fileInfo = new FileInfo(path);
			var fileInfoModel = new FileInfoModel();

			if (fileInfo.Exists)
			{
				fileInfoModel.Map(fileInfo);
			}

			return fileInfoModel;
		}

		public void DeleteFile(string path)
		{
			var fileInfo = new FileInfo(path);

			if (fileInfo.Exists)
			{
				fileInfo.Delete();
				// File.Delete(path);
			}
		}

		public void MoveFile(string path, string newPath)
		{
			var fileInf = new FileInfo(path);

			if (fileInf.Exists)
			{
				fileInf.MoveTo(newPath);
				// File.Move(path, newPath);
			}
		}

		public void CopyFile(string path, string newPath)
		{
			var fileInf = new FileInfo(path);

			if (fileInf.Exists)
			{
				fileInf.CopyTo(newPath, true);
				// File.Copy(path, newPath, true);
			}
		}
	}
}
