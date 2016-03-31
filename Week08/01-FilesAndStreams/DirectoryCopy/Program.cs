using System.IO;

namespace DirectoryCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string existDir =  @"../../TestDirectory";
            string newtargetDir =  @"../../TestDirectoryNew";

            CopyDirectory(existDir, newtargetDir, true);

        }

        static void CopyDirectory(string existDir, string targetDir, bool isRecursive)
        {
            DirectoryInfo directories = new DirectoryInfo(existDir);

            if (!directories.Exists)
            {
                throw new DirectoryNotFoundException(string.Format("The given directory not exist : {0}", directories.FullName));
            }

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            FileInfo[] files = directories.GetFiles();
            foreach (var file in files)
            {
                string temporaryPath = Path.Combine(targetDir, file.Name);
                file.CopyTo(temporaryPath, true);
            }

            if (isRecursive)
            {
                DirectoryInfo[] dirs = directories.GetDirectories();
                foreach (var dir in dirs)
                {
                    string tempPath = Path.Combine(targetDir, dir.Name);
                    CopyDirectory(dir.FullName, tempPath, isRecursive);
                }
            }
        }
    }
}
