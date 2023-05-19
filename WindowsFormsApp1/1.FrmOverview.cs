using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmOverview : Form
    {
        public FrmOverview()
        {
            InitializeComponent();
            this.tabControl1.SelectedIndex = this.tabControl1.TabCount-1;
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connected 連線環境
            //step: 1.SqlConnection
            //step: 2.sqlCommand
            //step  3.sqlDataReader
            //step  4.UI ListBox
            {
               // int iii;
                //嚴重性 程式碼 說明 專案 檔案 行 隱藏項目狀態錯誤  
                //    CS0165 使用未指派的區域變數 'iii'    
                //    WindowsFormsApp1 C:\Shared\Shared\student\ADO.NET\WindowsFormsApp1\WindowsFormsApp1\FrmOverview.cs 
                //-->要給iii值-->int iii = "";

                //MessageBox.Show(iii.ToString());
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("Select*from Products", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                this.listBox1.Items.Clear();//清空
                while (dataReader.Read())
                {
                    this.listBox1.Items.Add(dataReader[1]);
                }
                //MessageBox.Show("ProductName: " + dataReader[1]);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn!= null) 
                { conn.Close(); }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DisConnected 離線環境
            //step: 1.SqlConnection
            //step: 2.sqlDataApapter
            //step  3.DataSet
            //step  4.UI Control DataGridView
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from products", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);//auto connected - sqlConnection open  => sqlCommand... Exectexxx() => while(...dataReader()...) close)

            this.dataGridView1.DataSource= ds.Tables[0];//顯示Pproduct資料表第0欄
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //離線環境 選擇產品表單篩選價格大於30
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from products where UnitPrice >30",conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];//顯示Pproduct資料表第0欄
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //離線環境 選擇產品類別
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Categories", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[1];////顯示Categories資料表第1欄
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //產品
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dataGridView2.DataSource = this.nwDataSet1.Products;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //產品類別篩選
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //table篩選大於30 
            this.productsTableAdapter1.FillByMaxPrice(this.nwDataSet1.Products,30);
            this.dataGridView2.DataSource = this.nwDataSet1.Products;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.InsertProduct(DateTime.Now.ToString(), true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //table修改
            this.productsTableAdapter1.Update(this.nwDataSet1.Products);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.dataGridView2.DataSource = this.nwDataSet1.Customers;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            //this.dataGridView3.DataSource = this.nwDataSet1.Products;

            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView3.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count;           
        }     

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
            //this.bindingSource1.MoveNext();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position -=1;
        }        

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource1.Position + 1}/{this.bindingSource1.Count}";//顯示位置
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            //this.dataGridView3.DataSource = this.nwDataSet1.Products;

            this.bindingSource1.DataSource = this.nwDataSet1.Categories;
            this.dataGridView3.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;

            pictureBox1.DataBindings.Add("Image",bindingSource1,"Picture",true);
            label7.DataBindings.Add("Text",bindingSource1,"CategoryName");
        }       

        private void button17_Click(object sender, EventArgs e)
        {
            FrmTool f = new FrmTool();
            f.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = nwDataSet1.Categories;
            dataGridView5.DataSource = nwDataSet1.Products;
            dataGridView6.DataSource = nwDataSet1.Customers;                        
            
            for (int i=0;i<=nwDataSet1.Tables.Count-1;i++)
            {
                //table.topname
                DataTable table1 = nwDataSet1.Tables[i];                
                listBox2.Items.Add(table1.TableName);
                
                //table1.columns
                string s = "";
                for (int column =0;column<=table1.Columns.Count-1;column++)
                {
                    s += table1.Columns[column].ColumnName+"";
                }
                this.listBox2.Items.Add(s);
                
                //tablel.row
                for (int row = 0; row<table1.Rows.Count-1; row++)
                {
                    //DataRow dr = table1.Rows[row];
                    //listBox2.Items.Add(dr[0]);
                    //簡化如下
                    //this.listBox2.Items.Add(table1.Rows[row][0]);

                    //TODO1內迴圈
                    //table.row.column
                    string srs = "";
                    for (int rcol =0;rcol<table1.Columns.Count;rcol++)
                    {
                        srs += table1.Rows[row][rcol]+",";
                    }
                    listBox2.Items.Add(srs);   
                    //檢視.其他視窗.文件大綱...方便選擇所有物件
                }
                listBox2.Items.Add("==============================================");
            }           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //摺疊展開
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
            //if (this.splitContainer2.Panel1Collapsed == true)
            //  {
            //      this.splitContainer2.Panel1Collapsed = false;
            //  }
            //else
            //  {
            //      this.splitContainer2.Panel1Collapsed = true;
            //  }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Products.WriteXml("products.xml",XmlWriteMode.WriteSchema);
            //寫入位置-方案總管-所有檔案-bin-Debug-products.xml
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Products.Clear();//初始化有fill，因1是唯一值Read重複會產生錯誤，要先清空
            this.nwDataSet1.Products.ReadXml("product.xml");
            this.dataGridView5.DataSource = this.nwDataSet1.Products;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //week-complker Ok,Run time Error,"" 
            MessageBox.Show(this.nwDataSet1.Products.Rows[0]["ProductName"].ToString());

            //strong
            MessageBox.Show(this.nwDataSet1.Products[0].ProductName);
        }
    }
}
