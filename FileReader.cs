using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileMove
{
    /// <summary>
    /// 讀取檔案的物件 --逐行讀取檔案路徑 
    /// </summary>
    public class FileReader
    {

        public string Path { get; set; }

        public StreamReader StreamReader  { get; set; } 

        

        

        public FileReader(string path)
        {
            Path = path;
            StreamReader = new StreamReader(path);    
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        /// <param name="file">檔案的路徑</param>
        public List<string> ReadFileAndStorePath()
        {
            List<string> FilePathsList = new List<string>();

            string targetFilePath;
            while ((targetFilePath = StreamReader.ReadLine()) != null)
            {
                FilePathsList.Add(targetFilePath);
            }
            return FilePathsList;
        }
    }
}
