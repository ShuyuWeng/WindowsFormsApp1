using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.HomeWork
{
    public partial class FrmConnected : Form
    {
        public FrmConnected()
        {
            InitializeComponent();            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connected 連線環境
            //step 1.sqlConnection
            //step 2.sqlcommand
            //step 3.sqlDataReader
            //step 4.UI Control - listbox          
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand
                ($"select [ProductName],c.[CategoryID],[CategoryName] \r\n" +
                $"from [Products] p \r\n" +
                $"join [Categories]c \r\n" +
                $"on p.CategoryID = c.CategoryID \r\n" +
                $"where c.CategoryName='{comboBox1.Text}'", conn);
            SqlDataReader dataReader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (dataReader.Read())
            { this.listBox1.Items.Add(dataReader[0]); }
            conn.Close();

            //DisConnected 離線環境
            //step: 1.SqlConnection
            //step: 2.sqlDataApapter
            //step  3.DataSet
            //step  4.UI Control listBox
            //SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True");
            //DataSet ds = new DataSet();
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from products", conn);
            //adapter.Fill(ds,ProductName);
            //while (ds.read)
            //{
            //    listBox1.Items.Add(ds.Tables["ProductName"]);
            //}


            //this.categoriesTableAdapter1.FillByCategoryID(this.nwDataSet1.Categories);
            //this.listBox1.DataSource = this.nwDataSet1.Categories;

        }

        private void FrmConnected_Load(object sender, EventArgs e)
        {
            //Connected 連線環境
            //step 1.sqlConnection
            //step 2.sqlcommand
            //step 3.sqlDataReader
            //step 4.UI Control - combobox
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select*from Categories", conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox1.Items.Add(sqlDataReader[1]);
            }
            conn.Close();

            //DisConnected 離線環境
            //step: 1.SqlConnection
            //step: 2.sqlDataApapter
            //step  3.DataSet
            //step  4.UI Control combobox
            //using ()
            
        }    
    }
}
