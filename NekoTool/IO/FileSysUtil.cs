
using System.IO;
using System.Linq;

namespace NekoTool.IO
{
	public static class FileSysUtil
	{
		/// <summary>
		/// 确保文件夹存在，如果不存在则创建一个
		/// </summary>
		/// <param name="path"></param>
		public static void EnsureDirExists(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}

		public static DriveInfo GetDriveInfo(string driveName)
		{
			return DriveInfo.GetDrives().Single(di => di.Name.StartsWith(driveName));
		}
	}
}
