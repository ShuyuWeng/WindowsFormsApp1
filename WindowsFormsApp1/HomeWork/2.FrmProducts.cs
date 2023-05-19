using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.HomeWork
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text =$"{this.bindingSource1.Position+1}/{this.bindingSource1.Count}";
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            int? x = null;
            int? y = null;
            string z = null;
            
            int xValue;
            if (int.TryParse(txtmin.Text, out xValue))
            {
                x = xValue;
            }
            int yValue;
            if (int.TryParse(txtmax.Text, out yValue))
            {
                y = yValue;
            }           
            z = txtName.Text;

            if (x == null && y == null && string.IsNullOrEmpty(z))
            {
                MessageBox.Show("尚未輸入查詢欄位");
            }
            else if (x == null && y == null && z != null)
            {
                this.productsTableAdapter1.FillByName(nwDataSet1.Products, z);
                this.dataGridView1.DataSource = nwDataSet1.Products;
            }
            else if (x == null && y != null && string.IsNullOrEmpty(z))
            {
                this.productsTableAdapter1.FillByMin(nwDataSet1.Products, y);
                this.dataGridView1.DataSource = nwDataSet1.Products;
            }
            else if (x != null && y == null && string.IsNullOrEmpty(z))
            {
                this.productsTableAdapter1.FillByMaxPrice(nwDataSet1.Products, x);
                this.dataGridView1.DataSource = nwDataSet1.Products;
            }
            else if (x != null && y != null && string.IsNullOrEmpty(z))
            {
                int minX = Math.Min(x.Value, y.Value);
                int maxX = Math.Max(x.Value, y.Value);
                this.productsTableAdapter1.FillByPrice(nwDataSet1.Products,minX,maxX);
                this.dataGridView1.DataSource = nwDataSet1.Products;
            }
            else if (x != null && y != null && !string.IsNullOrEmpty(z))
            {
                int minX = Math.Min(x.Value, y.Value);
                int maxX = Math.Max(x.Value, y.Value);                
                this.productsTableAdapter1.FillByNamePrice(nwDataSet1.Products, minX, maxX, z);
                this.dataGridView1.DataSource = nwDataSet1.Products;

            }
            else if (x != null && y == null && !string.IsNullOrEmpty(z))
            {
                
                this.productsTableAdapter1.FillByMinName(nwDataSet1.Products, x, z);
                this.dataGridView1.DataSource = nwDataSet1.Products;

            }else if (x == null && y != null && !string.IsNullOrEmpty(z))
            {                
                this.productsTableAdapter1.FillByMaxName(nwDataSet1.Products,y,z);
                this.dataGridView1.DataSource = nwDataSet1.Products;
            }


        }
    }
}
