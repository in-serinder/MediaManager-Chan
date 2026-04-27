using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MediaManager_Chan
{
    class utility
    {
        //获取文件夹下的所有文件
        public static string[] GetFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }

        //获取指定文件类型的列表
        public static string[] GetFilesByExtension(string path, string filter)
        {
            if (!Directory.Exists(path))
                return new string[0];

            // 自动补通配符 *
            if (!filter.StartsWith("*."))
                filter = "*." + filter.TrimStart('.');

            string[] files = Directory.GetFiles(path, filter, SearchOption.TopDirectoryOnly);

            List<string> result = new List<string>();
            foreach (var fullPath in files)
            {
                result.Add(fullPath);
            }

            return result.ToArray();
        }

        //获取文件类型列表
        public static string[] GetFileExtensions(string[] files)
        {
            // 路径不存在返回空
            //if (files)
            //    return new string[0];

            // 获取所有文件
            string[] allFiles = files;

            // 存储不重复的后缀
            HashSet<string> extensions = new HashSet<string>();

            foreach (string file in allFiles)
            {
                // 获取后缀（自动带 .  例如 .txt）
                string ext = Path.GetExtension(file).ToLower(); // 转小写避免重复

                // 只加有后缀的文件
                if (!string.IsNullOrEmpty(ext))
                {
                    extensions.Add(ext);
                }
            }

            return extensions.ToArray();
        }

        //依据排序
        public static string[] SortFiles(string[] files, string sortType)
        {

//            文件大小
//原名a - z
//原名z - a
            switch (sortType)
            {
                case "文件大小":
                    return files.OrderByDescending(f =>
                    {
                        try { return new FileInfo(f).Length; }
                        catch { return 0; }
                    }).ToArray();
                case "a-z":
                    return files.OrderBy(f => Path.GetFileName(f)).ToArray();
                case "z-a":
                    return files.OrderByDescending(f => File.GetLastWriteTime(f)).ToArray();
                default:
                    return files; // 不排序
            }
        }

        public static string getSizeUtil(long size)
        {
            return size < 1024 ? $"{size} B" :
                   size < 1024 * 1024 ? $"{size / 1024.0:F2} KB" :
                   size < 1024 * 1024 * 1024 ? $"{size / (1024.0 * 1024):F2} MB" :
                   $"{size / (1024.0 * 1024 * 1024):F2} GB";
        }





    }
}
