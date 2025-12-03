using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AMS.ahutit.Common
{
    internal class FileIO
    {
        static void CopySingleFile(string sourceDir, string destinationDir)
        {
            // 获取源目录信息
            var dir = new DirectoryInfo(sourceDir);

            // 检查源目录是否存在
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"源目录未找到: {dir.FullName}");

            // 创建目标目录
            Directory.CreateDirectory(destinationDir);

            // 复制文件
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }            
        }
    }
}
