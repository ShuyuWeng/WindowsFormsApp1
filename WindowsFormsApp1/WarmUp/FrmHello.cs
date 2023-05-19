using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHello : Form
    {
        //constructor 建構主方法
        public FrmHello()
        {
            InitializeComponent();
            //...初始化
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello");

            // 嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態錯誤  
            //     CS0120 需要有物件參考，才可使用非靜態欄位、方法或屬性 '
            //     Form.Text' WindowsFormsApp1 E:\ADO.NET\WindowsFormsApp1\WindowsFormsApp1\Form1.cs  

            //Form1.Text = "Hello"+textBox1.Text;

            //===============================
            //錯誤寫法
            //Form1 f = new Form();
            //f.Text = "Hello" + textBox1.Text;
            //f.Show();
            //==============================

            //this.Text = "Hello" + this.textBox1.Text;//this-指當下的表單，this可縮小範圍，this可省略等同下列
            Text = "Hello  " + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string s = "xxx";
            FrmHello f = new FrmHello();
            f.Text = "Hello";
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form f3 = new Form();
            //f3.Show();

            //const int x = 100;
            //const double PI = 3.14;

            //Set Property 設屬性
            label1.Text = "Hello";
            label1.BackColor = Color.Indigo;
            label1.BorderStyle = BorderStyle.FixedSingle;
            button1.Visible = false;

            //get Property
            string s = label1.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //static property 靜態屬性 - 不用new 
            MessageBox.Show(SystemInformation.ComputerName);
            //嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態錯誤  
            //CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 
            //其為唯讀 WindowsFormsApp1    E:\ADO.NET\WindowsFormsApp1\WindowsFormsApp1\Form1.cs 

            //SystemInformation.ComputerName = "xxx";
            //==================================================================
            //instance property 非靜態屬性 - 先new -Text
            button1.Text = "aaa";
            button2.Text = "bbb";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //Cloes();
        }
    }
}
