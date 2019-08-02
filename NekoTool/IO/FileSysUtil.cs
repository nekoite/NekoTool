
using System.IO;
using System.Linq;

namespace NekoTool.IO
{
	public static class FileSysUtil
	{
		/// <summary>
		/// Ensures the existence of a directory. If it does not exist, then create one.
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
