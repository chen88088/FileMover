using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMove
{
    public class FileMover
    {
        /// <summary>
        /// 指定備份檔案的存放來源路徑起頭
        /// </summary>
        public string BackupSourcePathPrefix { get; set; }

        /// <summary>
        /// 指定儲存檔案的路徑起頭
        /// </summary>
        public string StorageFilePathPrefix { get; set; }


        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="backupSourcePathPrefix">備份檔案路徑開頭</param>
        public FileMover(string backupSourcePathPrefix, string storageFilePathPrefix)
        {            
            BackupSourcePathPrefix = backupSourcePathPrefix;
            StorageFilePathPrefix = storageFilePathPrefix;
        }



        /// <summary>
        /// 方法--任務:將檔案路徑加工成儲存檔案路徑
        /// </summary>
        /// <param name="waitMoveFilePath">備分檔案路徑</param>
        /// <returns>儲存檔案路徑</returns>
        public string GetFileStoragePath(string waitMoveFilePath)
        {
            // 用備份檔來源路徑開頭更新路徑
            return waitMoveFilePath.Replace(BackupSourcePathPrefix,StorageFilePathPrefix);

        }

        /// <summary>
        /// 方法--任務3:將修改好的路徑加入字典之Key
        /// </summary>
        /// <param name="fileChechWhetherExistDictionary">用來檢查備份檔案來源是否存在的字典</param>
        /// <param name="backupFilePath">備分檔案路徑</param>
        public void AddBackupFilePathIntoDictionary(Dictionary<string, string> fileChechWhetherExistDictionary, string backupFilePath, string storageFilePath)
        {
            if (storageFilePath != string.Empty)
            {
                if (!fileChechWhetherExistDictionary.Keys.Contains(backupFilePath))
                {
                    fileChechWhetherExistDictionary.Add(backupFilePath, storageFilePath);
                }
            }
        }

        /// <summary>
        /// 方法--任務4:確認備份來源中是否有所需檔案，若有則製作存放目的檔案路徑並完成搬運，再紀錄於字典 
        /// </summary>
        /// <param name="storageFilePathPrefix"></param>
        /// <param name="FileMovementDictionary"></param>
        public void MoveFile(string storageFilePathPrefix, Dictionary<string, string> FileMovementDictionary)
        {
            // 取得備份來源下的所有檔案路徑
            string[] backupSourceFilePaths = Directory.GetFiles(BackupSourcePathPrefix, "*", SearchOption.AllDirectories);

            foreach (string filePath in backupSourceFilePaths)
            {

                // 如果備份檔案中的路徑是有在名單內(字典的Keys)
                if (FileMovementDictionary.Keys.Contains(filePath)) 
                {
                    // 建立[目的地儲存檔案路徑]
                    string destinationStorageFilePath = filePath.Replace(BackupSourcePathPrefix, storageFilePathPrefix);

                    // 搬移檔案
                    File.Copy(filePath, destinationStorageFilePath, true);

                    // 將已完成搬移的[目的地儲存檔案路徑] 加入字典的對應Key之value
                    FileMovementDictionary[filePath] = destinationStorageFilePath;
                }
            }
            string movementCompleteMsg = "檔案搬運成功";
            MessageBox.Show(movementCompleteMsg);
        }
    }
}
