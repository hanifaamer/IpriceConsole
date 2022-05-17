using System;
using System.Diagnostics;
using System.IO;

namespace Iprice.Helper
{
    public static class FileHelper
    {
        public static bool CheckFolderExist(string folderPath, bool deleteFolder = false)
        {
            try
            {
                var isFolderExists = Directory.Exists(folderPath);

                if (!isFolderExists)
                    Directory.CreateDirectory(folderPath);

                if (deleteFolder)
                    Directory.Delete(folderPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured on the folder path checking. { ex.Message }");
                return false;
            }

            return true;
        }

        public static string GeneratePath(string folderPath, string fileName)
        {
            try
            {
                if (CheckFolderExist(folderPath))
                    return $"{folderPath}{fileName}";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return string.Empty;
        }

        public static string GenerateFileName(string fileName, string fileExtension, bool randomizeName = true)
        {
            if (randomizeName)
                return $"{fileName}_{Guid.NewGuid()}.{fileExtension}";
            
            return $"{fileName}.{fileExtension}";
        }

        public static string GenerateFile(string filePath, string processedData = "")
        {
            if (processedData == string.Empty)
                return string.Empty;

            try
            {
                File.WriteAllText(filePath, processedData);
                return filePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating the file. { ex.Message }");
                return string.Empty;
            }
        }

        public static bool OpenProgram(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo(filePath)
                        {
                            UseShellExecute = true
                        }
                    };
                    process.Start();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There's some error opening the program. { ex.Message }");
                return false;
            }
            return false;
        }
    }
}
