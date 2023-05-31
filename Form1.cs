using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用來待移動檔案路徑的list
        /// </summary>
        private static List<string> FileMoveList = new List<string>();

        /// <summary>
        /// 用來存放備份檔案路徑(key)/搬運檔案存放路徑(value)的字典
        /// </summary>
        private static Dictionary<string, string> FileMovementRecordDictionary = new Dictionary<string, string>();

        /// <summary>
        /// 用來存放比對項目(應該要搬運成功而存在的檔案)的List
        /// </summary>
        private static List<string> StoreFilePathCheckList = new List<string>();

        private void FileReadBnt_Click(object sender, EventArgs e)
        {
            // 清空--移動檔案清單list 
            FileMoveList.Clear();
            FileMovementRecordDictionary.Clear();
            StoreFilePathCheckList.Clear();
            BacpUpSourcePathPrefixTextBox.Text = string.Empty;
            FileStroragePathPrefixTextBox.Text = string.Empty;

            // 顯示讀檔路徑並且存到變數filePath
            string filePath = ReadFileShowPathOnTextBox();

            if (filePath == string.Empty)
            {
                // 使用者防呆: 點選"讀取檔案"按鈕，卻沒有選擇檔案讀取
                // 對策: 啥都不做
            }
            else
            {
                // 讀取檔案清單
                FileReader fileReader = new FileReader(filePath);
                FileMoveList = fileReader.ReadFileAndStorePath();
            }
        }

        /// <summary>
        /// 讀取檔案對話視窗抓取檔案路徑並顯示出來
        /// </summary>
        /// <returns>檔案路徑名稱</returns>
        public string ReadFileShowPathOnTextBox()
        {
            OpenFileDialog openReadFileDialog = new OpenFileDialog();

            openReadFileDialog.Title = "請開啟(.txt)檔案";
            string fileName = string.Empty;

            if (openReadFileDialog.ShowDialog() == DialogResult.OK)
            {
                //顯示路徑
                fileName = openReadFileDialog.FileName;
                FilePathTextBox.Text = fileName;
            }
            return fileName;
        }

        private void FileMoveBnt_Click(object sender, EventArgs e)
        {
            string backupSourcePathPrefix = BacpUpSourcePathPrefixTextBox.Text;
            string storageFilePathPrefix = FileStroragePathPrefixTextBox.Text;
            

            if (FileMoveList.Count() == 0)
            {
                 
            }
            else if (backupSourcePathPrefix == string.Empty)
            {
                string inputRemindMsg = "請輸入備份檔案路徑開頭";
                MessageBox.Show(inputRemindMsg);
            }
            else if (storageFilePathPrefix == string.Empty)
            {
                string inputRemindMsg = "請輸入檔案搬運存檔路徑開頭";
                MessageBox.Show(inputRemindMsg);
            }
            else
            {
                FileMover fileMover = new FileMover(backupSourcePathPrefix, storageFilePathPrefix);

                // 將備份檔案的路徑加入清查用的字典
                foreach (string waitMoveFilePath in FileMoveList)
                {

                    // 製作儲存路徑
                    string storageFilePath = fileMover.GetFileStoragePath(waitMoveFilePath);
                    // 製作檢查List
                    StoreFilePathCheckList.Add(storageFilePath);

                    if (!File.Exists(waitMoveFilePath))
                    {
                        continue;
                    }
                    string directory = Path.GetDirectoryName(storageFilePath);
                    Directory.CreateDirectory(directory);

                    // 搬移檔案
                    File.Copy(waitMoveFilePath, storageFilePath, true);

                   //fileMover.AddBackupFilePathIntoDictionary(FileMovementRecordDictionary, waitMoveFilePath, storageFilePath);
                }

                string movementCompleteMsg = "檔案搬運成功";
                MessageBox.Show(movementCompleteMsg);
            }
        }

        private void CheckCsvProduceBnt_Click(object sender, EventArgs e)
        {
            if (StoreFilePathCheckList.Count() ==0)
            {
                string checkRemindMsg = "請確認是否完成檔案搬運";
                MessageBox.Show(checkRemindMsg);
            }
            else
            {
                FileChecker fileChecker = new FileChecker(StoreFilePathCheckList);
                fileChecker.CheckWhetherFileMovementComplete();
                string reportMsg = "已產出清單";
                MessageBox.Show(reportMsg);
            }         
        }
    }
}
