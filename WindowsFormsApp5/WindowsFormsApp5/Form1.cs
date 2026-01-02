using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        // 類別變數 (Class Variable)(整個 Form1 可以存取的變數)
        string[] arrayStudentName; //學生姓名陣列
        int[] arrayStudentScore; //學生成績陣列
        string[] arrayTempStudentName; //學生姓名暫存陣列
        int[] arrayTempStudentScore; //學生成績暫存陣列

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayStudentName = new string[5]; //key-value (鍵值對應), key 姓名, index索引
            arrayStudentName[0] = "王小明";
            arrayStudentName[1] = "陳大貓";
            arrayStudentName[2] = "林玉珮";
            arrayStudentName[3] = "張文書";
            arrayStudentName[4] = "黃忠孝";

            arrayStudentScore = new int[5]; //value 成績
            arrayStudentScore[0] = 76;
            arrayStudentScore[1] = 68;
            arrayStudentScore[2] = 52;
            arrayStudentScore[3] = 94;
            arrayStudentScore[4] = 86;

            arrayTempStudentName = new string[5];
            arrayTempStudentScore = new int[5];

            lbl成績總和.Text = $"{計算總分(arrayStudentScore)}";
            lbl成績平均.Text = $"{計算平均(arrayStudentScore):F}";
        }

        int 計算總分(int[] myArrayScore)
        {
            int sum = 0;

            foreach (int score in myArrayScore)
            {
                sum += score;
            }

            return sum;
        }

        double 計算平均(int[] myArrayScore)
        {
            double avg = 0;

            avg = Convert.ToDouble(計算總分(myArrayScore)) / myArrayScore.Length;

            return avg;
        }

        void 姓名排序(string[] myArrayName )
        {
            Array.Sort(myArrayName); //標點符號, 0-9, a-z, 中文筆畫由少到多

            string strMsg = "";

            for (int i = 0; i < myArrayName.Length; i += 1)
            {
                strMsg += $"姓名: {myArrayName[i]}\r\n";
            }

            txt查詢結果.Text = strMsg;
        }


        private void btn姓名排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            姓名排序(arrayTempStudentName);
        }

        void 成績排序(string[] myArrayName, int[] myArrayScore)
        {
            Array.Sort(myArrayScore, myArrayName); //維持key-value一致

            string strMsg = "";

            for (int i = (myArrayName.Length - 1); i >= 0; i -= 1)
            {
                strMsg += $"姓名: {myArrayName[i]}, 成績: {myArrayScore[i]}分\r\n";
            }

            txt查詢結果.Text = strMsg;
        }

        private void btn成績排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);
            成績排序(arrayTempStudentName, arrayTempStudentScore);
        }

        void 列出所有學生成績()
        {
            string strMsg = "";

            for (int i = 0; i < arrayStudentName.Length; i += 1)
            {
                strMsg += $"姓名: {arrayStudentName[i]}, 成績: {arrayStudentScore[i]} 分 \r\n";
            }

            txt查詢結果.Text = strMsg;
        }

        private void btn列出所有學生_Click(object sender, EventArgs e)
        {
            列出所有學生成績();
        }

        private void btn姓名搜尋_Click(object sender, EventArgs e)
        {
            if (txt搜尋關鍵字.Text != "")
            {
                int index, 名次 = 0;
                string strMsg = "搜尋結果\r\n---------------------------------\r\n";
                string str搜尋姓名 = txt搜尋關鍵字.Text;

                Array.Copy(arrayStudentName,arrayTempStudentName,arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentScore,arrayStudentScore.Length);
                成績排序(arrayTempStudentName, arrayTempStudentScore);

                //搜尋array中的元素, 結果會以索引值傳回
                index = Array.IndexOf(arrayTempStudentName, str搜尋姓名); //index跟名次有關, 但不是名次

                if (index == -1)
                { //找不到
                    strMsg += "查無此人";
                }
                else
                { //找到了
                    名次 = arrayTempStudentName.Length - index;
                    strMsg += $"姓名 {arrayTempStudentName[index]} 成績 {arrayTempStudentScore[index]} 第{名次}名";
                }

                txt查詢結果.Text = strMsg;
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋");
            }
        }

        /////////////////////////////////////////////////////////////
        /// 練習題:
        /// Windows Form App 包含設計使用者介面
        /// 題目: 設計App, 求得質數(Prime)相關的功能
        /// Button 1. 求得ulong的最大質數
        /// Button 2. 寫一個判斷質數的方法, 代入任一個ulong 的參數, 判斷是否是質數, 是的話回傳值是true, 反之是false
        /// Button 3. 寫一個方法, 從2開始增加, 不斷列出質數, TextBox呈現結果.
        /// 使用TextBox紀錄1和2操作任務, 所花費的時間, 提示: 定義DateTime變數是可以相減的
        /// 練習三步驟(1. 自己 2. 部落客文章 3. AI工具 )

    }
}
