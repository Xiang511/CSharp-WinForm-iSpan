using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        //類別變數
        List<ArrayList> list員工資料集合 = new List<ArrayList>();
        List<Hashtable> list會員資料集合 = new List<Hashtable>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("************ List Demo ************");

            List<int> myIntList = new List<int>();
            myIntList.Add(1); //index:0
            myIntList.Add(2);
            myIntList.Add(3);
            myIntList.Add(4); //index:3
            myIntList.Add(5);
            myIntList.Add(6); //index:5

            Console.WriteLine($"索引為3的元素是 {myIntList[3]}");
            myIntList[4] = 99;
            Console.WriteLine($"索引為4的元素是 {myIntList[4]}");

            for (int i = 0; i < myIntList.Count; i += 1)
            {
                Console.WriteLine($"myIntList[{i}] = {myIntList[i]}");
            }

            Console.WriteLine("--------------------------------------------");

            List<int> myIntList2 = new List<int>() { 6,5,4,3,2,1 };

            myIntList2.Add(7);

            for (int i = 0; i < myIntList2.Count; i += 1)
            {
                Console.WriteLine($"myIntList2[{i}] = {myIntList2[i]}");
            }

            Console.WriteLine("--------------------------------------------");

            List<string> myStringList = new List<string>();
            myStringList.Add("red");
            myStringList.Add("yellow");
            myStringList.Add("blue");
            myStringList.Add("purple");
            myStringList.Add("green");

            Console.WriteLine("================ 列出List的元素 ================");
            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }

            Console.WriteLine("================ 修改List的元素 ================");
            myStringList[1] = "lightyellow";
            myStringList[2] = "darkblue";

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ Insert 在中間插入元素 ================");
            myStringList.Insert(2, "skyblue");

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ InsertRange 在中間插入List ================");
            List<string> myNewStringList = new List<string>() { "gray", "brown", "pink" };
            myStringList.InsertRange(3, myNewStringList);

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ AddRange 在最後加入List ================");
            myStringList.AddRange(myNewStringList); //從最後一個之後加入

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ 移除List元素 =================");
            myStringList.Remove("gray");//只會移除第一個符合的元素
            myStringList.RemoveAt(3);//移除索引為3, 其後所有元素索引都減1
            myStringList.RemoveRange(4, 3); //移除索引值為4開始的3個元素, 移出之後, 其後所有元素索引都減3

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ Sort 排序 List元素 ================");
            myStringList.Sort(); //標點符號, 0-9, a-z, 中文筆畫由少到多

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ Reverse 反轉List元素順序 ================");
            myStringList.Reverse();

            foreach (string color in myStringList)
            {
                Console.WriteLine($"{color}");
            }
            Console.WriteLine("================ IndexOf 搜尋 ================");
            int index = myStringList.IndexOf("pink");
            Console.WriteLine($"第一個符合pink的索引: {index}");

            Console.WriteLine("================ List 轉換 Array ================");
            string[] myTempArray = myStringList.ToArray();
            Console.WriteLine("================ Array 轉換 List ================");
            List<string> myTempList = myTempArray.ToList();
            Console.WriteLine("================ clear ===============");
            myStringList.Clear(); //清除所有元素

            Console.WriteLine($"count: {myStringList.Count}");
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== ArrayList Demo ===============");
            System.Collections.ArrayList myPersonInfoOne = new System.Collections.ArrayList();
            myPersonInfoOne.Add("王小明");
            myPersonInfoOne.Add(35000);
            myPersonInfoOne.Add(DateTime.Now);
            myPersonInfoOne.Add("0912-345-678");
            myPersonInfoOne.Add("高雄市前金區中正路8888號");
            myPersonInfoOne.Add(170.0);
            myPersonInfoOne.Add(26);
            myPersonInfoOne.Add(false);

            ArrayList myPersonInfoTwo = new ArrayList();
            myPersonInfoTwo.Add("張大書");
            myPersonInfoTwo.Add(48000);
            myPersonInfoTwo.Add(new DateTime(2010,1,2,0,0,0));
            myPersonInfoTwo.Add("0966-888-999");
            myPersonInfoTwo.Add("台南市東區中華路6666號");
            myPersonInfoTwo.Add(173.0);
            myPersonInfoTwo.Add(38);
            myPersonInfoTwo.Add(true);

            list員工資料集合.Add(myPersonInfoOne);
            list員工資料集合.Add(myPersonInfoTwo);

            foreach (ArrayList 員工 in list員工資料集合)
            {
                string 姓名 = Convert.ToString(員工[0]);
                int 薪資 = Convert.ToInt32(員工[1]);
                DateTime 到職日 = Convert.ToDateTime(員工[2]);
                string 電話 = Convert.ToString(員工[3]);
                string 地址 = Convert.ToString(員工[4]);
                double 身高 = Convert.ToDouble(員工[5]);
                int 年齡 = Convert.ToInt32(員工[6]);
                bool 婚姻狀態 = Convert.ToBoolean(員工[7]);

                string strMsg = $"{姓名} {薪資} {到職日:D} {電話} {地址} {身高} {年齡} {婚姻狀態}\n";

                Console.WriteLine(strMsg);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("========================================");
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== Dictionary Demo ===============");
            Dictionary<string, int> dictNameScore = new Dictionary<string, int>();
            dictNameScore.Add("王小明", 84);
            dictNameScore.Add("陳大貓", 72);
            dictNameScore.Add("林玉珮", 93);
            dictNameScore.Add("張大書", 74);
            dictNameScore.Add("黃忠孝", 69);

            Console.WriteLine($"陳大貓 {dictNameScore["陳大貓"]}分");
            dictNameScore["黃忠孝"] = 76;
            Console.WriteLine($"黃忠孝 {dictNameScore["黃忠孝"]}分");

            Console.WriteLine("-----------------------------------------------");
            foreach (KeyValuePair<string, int> myKeyValue in dictNameScore)
            {
                Console.WriteLine($"姓名: {myKeyValue.Key} 成績: {myKeyValue.Value}");
            }
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < dictNameScore.Count; i += 1)
            {
                string 姓名 = dictNameScore.ElementAt(i).Key;
                int 成績 = dictNameScore.ElementAt(i).Value;
                Console.WriteLine($"姓名: {姓名} 成績: {成績}");
            }
            Console.WriteLine("-----------------------------------------------");
            foreach (string key in dictNameScore.Keys)
            {
                Console.WriteLine($"姓名: {key} 成績: {dictNameScore[key]}");
            }
            Console.WriteLine("-----------------------------------------------");
            foreach (int score in dictNameScore.Values)
            {
                Console.WriteLine($"成績: {score}");
            }
            Console.WriteLine("-----------------------------------------------");
            string strSearchKey = "林玉珮";
            bool is有key = dictNameScore.ContainsKey(strSearchKey);
            if (is有key)
            {
                Console.WriteLine($"有這個key {strSearchKey}, 成績 {dictNameScore[strSearchKey]}");
            }
            else
            {
                Console.WriteLine("查無此key");
            }
            Console.WriteLine("-----------------------------------------------");
            int intSearchValue = 93;
            bool is有Value = dictNameScore.ContainsValue(intSearchValue);
            if (is有Value)
            {
                Console.WriteLine($"有這個分數 {intSearchValue}");
            }
            else
            {
                Console.WriteLine("查無此分數");
            }
            Console.WriteLine("-----------------------------------------------");
            dictNameScore.Remove("黃忠孝");

            foreach (string key in dictNameScore.Keys)
            {
                Console.WriteLine($"姓名: {key} 成績: {dictNameScore[key]}");
            }
            Console.WriteLine("-----------------------------------------------");
            string[] arrayKeys = dictNameScore.Keys.ToArray();
            int[] arreayValues = dictNameScore.Values.ToArray();
            List<string> listKeys = dictNameScore.Keys.ToList();
            List<int> listValues = dictNameScore.Values.ToList();
            Console.WriteLine("-----------------------------------------------");

            dictNameScore.Clear();

            Console.WriteLine($"count : {dictNameScore.Count}");
            Console.WriteLine("-----------------------------------------------");
        }

        private void btnHashtable_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=================== Hashtable Demo ==================");
            System.Collections.Hashtable memberInfoOne = new System.Collections.Hashtable();
            memberInfoOne.Add("姓名", "王大衛");
            memberInfoOne.Add("年齡", 30);
            memberInfoOne.Add("身高", 175.0);
            memberInfoOne.Add("電話", "0987-321-456");
            memberInfoOne.Add("婚姻狀態", false);
            memberInfoOne.Add("點數", 2400);

            Hashtable memberInfoTwo = new Hashtable();
            memberInfoTwo.Add("姓名","李瑪莉");
            memberInfoTwo.Add("點數", 560);
            memberInfoTwo.Add("身高", 161.0);
            memberInfoTwo.Add("年齡", 36);
            memberInfoTwo.Add("婚姻狀態", true);
            memberInfoTwo.Add("電話", "07-888-1234");

            list會員資料集合.Add(memberInfoOne);
            list會員資料集合.Add(memberInfoTwo);

            Console.WriteLine("-----------------------------------------------");

            foreach (DictionaryEntry 欄位資料 in memberInfoOne)
            {
                Console.WriteLine($"key: {欄位資料.Key} value: {欄位資料.Value}");
            }

            Console.WriteLine("-----------------------------------------------");

            foreach (Hashtable 會員資料 in list會員資料集合)
            {
                foreach (DictionaryEntry 欄位資料 in 會員資料)
                {
                    Console.WriteLine($"key: {欄位資料.Key} value: {欄位資料.Value}");
                }
                Console.WriteLine("*****************************");
            }

            Console.WriteLine("-----------------------------------------------");
            string str欄位名稱 = "姓名";

            if (memberInfoOne.Contains(str欄位名稱) == true) 
            {
                Console.WriteLine($"{str欄位名稱} : {memberInfoOne[str欄位名稱]}");
            }

            Console.WriteLine("-----------------------------------------------");

            memberInfoOne.Remove("年齡");

            foreach (DictionaryEntry 欄位 in memberInfoOne)
            {
                Console.WriteLine($"key: {欄位.Key}, value: {欄位.Value}");
            }

            Console.WriteLine("-----------------------------------------------");
            //清除集合內容

            foreach (Hashtable member in list會員資料集合)
            {
                member.Clear();
            }

            list會員資料集合.Clear();

            Console.WriteLine($"memberInfoOne count:{memberInfoOne.Count} \n memberInfoTwo count:{memberInfoTwo.Count}");

        }
    }
}
