using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
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

            // 建立一個整數型別的 List
            List<int> myIntList = new List<int>();
            myIntList.Add(1); //index:0 - 新增元素1到List中
            myIntList.Add(2); // 新增元素2
            myIntList.Add(3); // 新增元素3
            myIntList.Add(4); //index:3 - 新增元素4，位於索引3
            myIntList.Add(5); // 新增元素5
            myIntList.Add(6); //index:5 - 新增元素6，位於索引5
            // 透過索引存取List元素並輸出
            Console.WriteLine($"索引為3的元素是 {myIntList[3]}");




            List<String> myStringLIst = new List<string>();
            myStringLIst.Add("red");
            myStringLIst.Add("yellow");
            myStringLIst.Add("blue");
            myStringLIst.Add("purple");
            myStringLIst.Add("green");

            //使用foreach迴圈輸出List內容
            foreach (string color in myStringLIst)
            {
                Console.WriteLine(color);
            }
            //使用for迴圈輸出List內容
            //for (int i = 0; i < myStringLIst.Count; i++)
            //{
            //    Console.WriteLine(myStringLIst[i]);
            //}

            Console.WriteLine("-------------------插入元素------------------------");

            myStringLIst.Insert(2, "skyblue");

            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            //會改變索引
            Console.WriteLine($"元素已加入");

            Console.WriteLine("-------------------InsertRange在中間插入list------------------------");
            List<string> StringList = new List<string>() { "black", "white" };
            myStringLIst.InsertRange(3, StringList);
            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            Console.WriteLine($"已經在中間插入list");

            Console.WriteLine("-------------------AddRange在最加入List------------------------");
            List<string> StringList2 = new List<string>() { "pink", "brown" };
            myStringLIst.AddRange(StringList2);
            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            Console.WriteLine($"已經在最加入List");

            Console.WriteLine("-------------------移除list元素------------------------");
            //移除
            myStringLIst.Remove("purple");

            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }

            Console.WriteLine($"purple已經被移除");

            Console.WriteLine("-------------------利用RemoveAt移除list元素------------------------");

            myStringLIst.RemoveAt(0); //移除索引0的元素

            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            Console.WriteLine($"移除索引0的元素:red");

            Console.WriteLine("-------------------利用RemoveRange移除list元素------------------------");
            myStringLIst = new List<string>() { "red", "yellow", "blue", "purple", "green", "pink", "brown" };
            myStringLIst.RemoveRange(1, 3); // 移除索引1開始的3個元素

            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            Console.WriteLine($"移除索引1開始的3個元素");

            Console.WriteLine("-------------------利用Sort排列list元素------------------------");
            myStringLIst = new List<string>() { "red", "0", "1", "詳", "你好", "pink", "brown" };
            myStringLIst.Sort(); //排序 0-9 A-Z 中文筆畫由少到多
            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            Console.WriteLine(myStringLIst);


            Console.WriteLine("-------------------Reverse 反轉list元素------------------------");
            myStringLIst.Reverse(); //反轉
            for (int i = 0; i < myStringLIst.Count; i++)
            {
                Console.WriteLine(myStringLIst[i]);
            }
            Console.WriteLine(myStringLIst);

            Console.WriteLine("-------------------IndexOf------------------------");
            int index = myStringLIst.IndexOf("pink");
            Console.WriteLine($"pink的索引值為: {index}");

            Console.WriteLine("-------------------list轉array------------------------");
            string[] myTempArray = myStringLIst.ToArray();
            Console.WriteLine(myTempArray.GetType().Name);

            Console.WriteLine("-------------------array轉list------------------------");
            List<String> myTempList = myTempArray.ToList();
            Console.WriteLine(myTempList.GetType().Name);

            Console.WriteLine("-------------------clear------------------------");
            myStringLIst = new List<string>() { "red", "0", "1", "詳", "你好", "pink", "brown" };
            myStringLIst.Clear();
            if (myStringLIst.Count == 0)
            {
                Console.WriteLine($"該list已被清空");
            }






        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-------------------ArrayList------------------------");

            List<ArrayList> AllList = new List<ArrayList>();
            ArrayList list = new ArrayList();

            list.Add("小名");
            list.Add(25);
            list.Add(175.5);
            list.Add(true);
            list.Add(false);
            list.Add(DateTime.Now);

            //String listitem = (string)list[0];
            //Console.WriteLine(listitem);

            ArrayList list2 = new ArrayList();

            list.Add("大名");
            list.Add(25);
            list.Add(175.5);
            list.Add(true);
            list.Add(false);
            list.Add(DateTime.Now);


            AllList.Add(list);
            AllList.Add(list2);



            for (int i = 2; i <= AllList.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    Console.WriteLine(list[j]);
                }
            }

            //Console.WriteLine(AllList);
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Apple", 1);
            myDictionary.Add("Banana", 2);
            myDictionary.Add("Orange", 3);
            Console.WriteLine($"{myDictionary["Apple"]}"); // 使用key存取value並輸出
            myDictionary["Apple"] = 10; // 修改key對應的value
            Console.WriteLine($"{myDictionary["Apple"]}"); // 使用key存取value並輸出

            //foreach (KeyValuePair<string, int> kvp in myDictionary)
            //{
            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            //}

            for (int i = 0; i < myDictionary.Count; i++)
            {
                string key = myDictionary.ElementAt(i).Key;
                int number = myDictionary.ElementAt(i).Value;
                Console.WriteLine(key + number);
            }

            foreach (var key in myDictionary.Keys)
            {
                Console.WriteLine($"Key: {key}");
            }

            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine($"Value: {value}");
            }

            string searchKey = "Banana";
            if (myDictionary.ContainsKey(searchKey))
            {
                int value = myDictionary[searchKey];
                Console.WriteLine($"Dictionary contains key: {searchKey} val:{value}");
            }
            else
            {
                Console.WriteLine($"Dictionary does not contain key: {searchKey}");
            }

            string removeKey = "Orange";
            if (myDictionary.Remove(removeKey))
            {
                Console.WriteLine($"Removed key: {removeKey}");
            }
            else
            {
                Console.WriteLine($"Key not found: {removeKey}");
            }



            string[] keysArray = myDictionary.Keys.ToArray();
            int[] valuesArray = myDictionary.Values.ToArray();
            List<string> keysList = myDictionary.Keys.ToList();
            List<int> valuesList = myDictionary.Values.ToList();

        }

        private void btnHashtable_Click(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Name", "John");
            hashtable.Add("Age", 30);
            //Console.WriteLine($"Name: {hashtable["Name"]}, Age: {hashtable["Age"]}");

            Hashtable hashtable2 = new Hashtable();
            hashtable2.Add("Name", "toby");
            hashtable2.Add("Age", 31);
            //Console.WriteLine($"City: {hashtable2["City"]}, Country: {hashtable2["Country"]}");


            List<Hashtable> allHashtables = new List<Hashtable>();
            allHashtables.Add(hashtable);
            allHashtables.Add(hashtable2);

            //foreach (Hashtable table in allHashtables)
            //{
            //    foreach (DictionaryEntry row in table)
            //    {
            //        Console.WriteLine($"Key: {row.Key}, Value: {row.Value}");
            //    }

            //}


            string nameKey = "Name";

            foreach (Hashtable table in allHashtables)
            {
                if (table.Contains(nameKey))
                {
                    Console.WriteLine($"Found hashtable with Name: {nameKey}, name:{table["Name"]} Age: {table["Age"]}");
                }
                else
                {
                    Console.WriteLine($"Hashtable does not contain Name: {nameKey}");
                }
            }

            //清除allHashtables
            allHashtables.Clear();
            Console.WriteLine(allHashtables.Count);

        }
    }
}
