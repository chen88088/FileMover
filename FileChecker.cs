using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMove
{
    public class FileChecker
    {
        public List<string>  MovementCheckList { get; set; }

        // 建立 Dictionary 物件
        public Dictionary<string, string> ReportData { get; set; }

        public FileChecker(List<string> movementCheckList)
        {
            MovementCheckList = movementCheckList;
            ReportData =  new Dictionary<string, string>();
        }

        public void CheckWhetherFileMovementComplete()
        {
            ReportData.Clear();
            foreach (string path in MovementCheckList)
            {

                if (File.Exists(path))
                {
                    string successMsg = "移動成功";
                    ReportData.Add(path, successMsg);
                }
                else
                {
                    string failMsg = "移動失敗";
                    ReportData.Add(path, failMsg);
                }
            }


            // 使用 SaveFileDialog 讓使用者指定存放位置與檔名
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV 檔 (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvPath = saveFileDialog.FileName;

                // 建立 StreamWriter 物件
                using (StreamWriter writer = new StreamWriter(csvPath))
                {
                    
                    // 寫入標題行
                    writer.WriteLine("檢查結果, 目標檔案路徑");

                    // 寫入每一行資料
                    foreach (KeyValuePair<string, string> pair in ReportData)
                    {
                        writer.WriteLine($"{pair.Value}, {pair.Key}");
                    }
                }
            }
        }
    }
}
