using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("=================== string 字串的進階應用 ====================");
            string strURL = @"c:\windows\notes\reload\test.text"; //@符號,不處理特殊符號控制碼, 純字串
            Console.WriteLine(strURL);

            string strOne = "Hello World !! C# String World";
            Console.WriteLine(strOne);
            Console.WriteLine($"strOne長度, {strOne.Length} 個字元");

            int idx = strOne.IndexOf("World");
            Console.WriteLine($"第一個World字串裡的第一個字元的索引: {idx}");
            Console.WriteLine($"這個字元是: {strOne[idx]}");

            Console.WriteLine("---------------------------------------------");
            string strTwo = strOne.Insert(6, "Hi ");
            Console.WriteLine(strTwo);

            string strThree = strOne.Remove(6); //移除索引開始直到最後一個字元
            Console.WriteLine(strThree);

            string strFour = strOne.Remove(12, 3);
            Console.WriteLine(strFour);

            string strFive = strOne.Replace("World", "Earth"); //全部取代
            Console.WriteLine(strFive);

            string strSix = strOne.Substring(6); //擷取字串
            Console.WriteLine(strSix);

            string strSeven = strOne.Substring(15, 2); //擷取字串
            Console.WriteLine(strSeven);

            string strEight = strOne.ToLower(); //轉換成小寫字元
            Console.WriteLine(strEight);
            string strNight = strOne.ToUpper(); //轉換成大寫字元
            Console.WriteLine(strNight);

            bool is包含字串 = strOne.Contains("C#");
            Console.WriteLine($"有無C#字串: {is包含字串}");

            char charOne = strOne[6];
            Console.WriteLine(charOne);

            // strOne[6] = 'x'; //錯誤

            string strSpaceOne = "        Visual Studio       ";
            string strTrim = strSpaceOne.Trim(); //去除字串前後的所有空白
            Console.WriteLine(strTrim);

            Console.WriteLine("-------------------------------------------");

            string strCollections = "珍珠|波霸|QQ|椰果|芋圓|地瓜|仙草|綠豆|紅豆";
            char charSpilt = '|';
            string[] array冰品配料 = strCollections.Split(charSpilt);

            Console.WriteLine($"共 {array冰品配料.Length} 種配料");

            foreach(string 配料 in array冰品配料)
            {
                Console.WriteLine(配料);
            }



        }
    }
}
