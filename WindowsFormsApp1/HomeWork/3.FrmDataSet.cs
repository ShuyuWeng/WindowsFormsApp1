using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.HomeWork
{
    public partial class FrmDataSet : Form
    {
        public FrmDataSet()
        {
            InitializeComponent();
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = nwDataSet1.Categories;
            dataGridView5.DataSource = nwDataSet1.Products;
            dataGridView6.DataSource = nwDataSet1.Customers;
            //排版
            int[][] columnwidth = new int[nwDataSet1.Tables.Count][];
            for (int i = 0; i <= nwDataSet1.Tables.Count - 1; i++)
            {
                //table.topname
                DataTable table1 = nwDataSet1.Tables[i];
                listBox2.Items.Add(table1.TableName);

                //Columnwidth
                columnwidth[i] = new int[table1.Columns.Count];
                for (int column = 0; column < table1.Columns.Count; column++)
                {
                    int w = table1.Columns[column].ColumnName.Length;
                    for (int row = 0; row < table1.Rows.Count; row++)
                    {
                        if (table1.Rows[row][column].ToString().Length > w)
                        { w = table1.Rows[row][column].ToString().Length; }
                    }
                    columnwidth[i][column] = w + 3;
                }

                //table1.columns
                string s = "";
                for (int column = 0; column <= table1.Columns.Count - 1; column++)
                {
                    string temp = "," + columnwidth[i][column].ToString();
                    s += table1.Columns[column].ColumnName.PadRight(columnwidth[i][column]);
                }
                this.listBox2.Items.Add(s);

                //tablel.row
                for (int row = 0; row < table1.Rows.Count - 1; row++)
                {                   
                    //table.row.column
                    string srs = "";
                    for (int rcol = 0; rcol < table1.Columns.Count; rcol++)
                    {
                        srs += table1.Rows[row][rcol].ToString().PadRight(columnwidth[i][rcol]);
                    }
                    listBox2.Items.Add(srs);
                }
                listBox2.Items.Add("================================================================================");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2Collapsed = !this.splitContainer2.Panel2Collapsed;
        }
    }
}
