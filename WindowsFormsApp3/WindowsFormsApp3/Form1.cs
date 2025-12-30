using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            顯示歡迎訊息();
        }

        void 顯示歡迎訊息()
        { //void 代表沒有回傳值
            MessageBox.Show("歡迎使用本程式");
        }

        private void btn方法1_Click(object sender, EventArgs e)
        {
            //顯示歡迎訊息();
            顯示訂購資訊("iPhone 17 Pro", 36000.0, 2, "John Lee", true);
        }

        void 顯示訂購資訊(string product, double price, int amount, string customer, bool isPay)
        {  //方法的參數(parameters) , 方法內的區域變數(local variable)

            MessageBox.Show($"Dear {customer},\n您購買了{product}, {amount}台\n單價 {price}元\n總價 {price * amount}元\n是否已付款 {isPay}\n謝謝光臨");
        }

        string 顯示訂購資訊2(string product, double price, int amount, string customer, bool isPay)
        {
            string str訂購資訊 = $"Dear {customer},\n您購買了{product}, {amount}台\n單價 {price}元\n總價 {price * amount}元\n是否已付款 {isPay}\n謝謝光臨";

            return str訂購資訊;
        }

        private void btn方法2_Click(object sender, EventArgs e)
        {
            string my訂購資訊 = 顯示訂購資訊2("Samsung Galaxy s25", 28000.0,3,"Mary Wang", false);
            MessageBox.Show(my訂購資訊);
        }

        int 總和(int a, int b , int c, int d, int e)
        {
            int sum = a + b + c + d + e;
            return sum; //回傳值
        }

        double 平均(int a, int b, int c, int d, int e)
        {
            double avg = 0.0;
            avg = Convert.ToDouble(總和(a, b, c, d, e)) / 5;
            return avg;
        }

        private void btn方法3_Click(object sender, EventArgs e)
        {
            int mySum = 總和(1,3,6,9,12);
            MessageBox.Show($"總和: {mySum}");

            double myAvg = 平均(1,3,6,9,12);
            MessageBox.Show($"平均: {myAvg}");
        }

        private void btn方法4_Click(object sender, EventArgs e)
        {

        }
    }
}
