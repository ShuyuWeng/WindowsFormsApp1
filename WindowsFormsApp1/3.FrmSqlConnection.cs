using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class FrmSqlConnection : Form
    {
        public FrmSqlConnection()
        {
            InitializeComponent();
            //this.button1.Click+= button1_Click; //syntax sugar
            //this.button1.Click += new EventHandler(this.button1_Click);
            //選EventHandler右移至定義或F12->
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //語法糖 using(...){...}
            try//驗證
            {
                using (SqlConnection conn = new SqlConnection("Data Source = .;Initial Catalog = Northwind; Integrated Security=True"))
                {
                    conn.StateChange += conn_StageChange;//點擊發生事件(conn_StageChange)

                    conn.Open();
                    SqlCommand command  = new SqlCommand("Select*from products",conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        this.listBox1.Items.Add(dataReader["ProductName"]);
                    }
                    
                }//auto conn.close()=>conn.Dispose() 自動關閉，關閉後消失釋放記憶體
            }
            catch(Exception ex)//驗證錯誤-顯示錯誤訊息
            {
                MessageBox.Show(ex.Message);
            }           
            //SqlConnection conn = new SqlConnection("Data Source = .;Initial Catalog = Northwind; Integrated Security=True");
            //conn.Open();
            //MessageBox.Show(conn.State.ToString());
            //conn.Close();
        }

        private void conn_StageChange(object sender,StateChangeEventArgs e)
        {
            //this.label1.Text = e.CurrentState.ToString();
            this.toolStripLabel1.Text = e.CurrentState.ToString();//將訊息顯示在狀態列
            Application.DoEvents();//消化完前面的資料後停駐訊息
            System.Threading.Thread.Sleep(700);//物件睡眠0.7秒
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source = .;Initial Catalog = Northwind; User ID = sa;Password=123");
            //conn.Open();
            //MessageBox.Show(conn.State.ToString());
            //conn.Close();
                        
            try //驗證
            {
                using (SqlConnection conn = new SqlConnection("Data Source = .;Initial Catalog = Northwind; User ID = sa;Password=123"))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select*from products", conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        this.listBox1.Items.Add(dataReader["ProductName"]);
                    }
                }//auto conn.close()=>conn.Dispose()
            }
            catch (Exception ex)//驗證錯誤顯示錯誤訊息
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.productsTableAdapter1.Connection.ConnectionString);//轉接頭連接連線狀態字串

            this.productsTableAdapter1.Connection.StateChange += conn_StageChange;//轉接頭連接狀態改變呼叫conn_StageChange方法
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            try//驗證
            {                
                using (SqlConnection conn = new SqlConnection())
                {
                    //string connstring = System.Configuration.ConfigurationManager.ConnectionStrings[0].connection;
                    string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    conn.StateChange += conn_StageChange;//點擊發生事件(conn_StageChange)

                    conn.Open();
                    SqlCommand command = new SqlCommand();// ("Select*from products", conn);
                    command.CommandText = "Select*from products";
                    command.Connection = conn;

                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        this.listBox1.Items.Add(dataReader["ProductName"]);
                    }

                }//auto conn.close()=>conn.Dispose() 自動關閉，關閉後消失釋放記憶體
            }
            catch (Exception ex)//驗證錯誤-顯示錯誤訊息
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //加密
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSection section = config.Sections["connectionStrings"];
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
                MessageBox.Show("加密成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //解密
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSection section = config.Sections["connectionStrings"];
                section.SectionInformation.UnprotectSection();
                config.Save();
                MessageBox.Show("解密成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
