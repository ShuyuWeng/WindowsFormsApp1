using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1.HomeWork
{
    public partial class FrmAW : Form
    {
        public FrmAW()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.productPhotoDataGridView.DataSource = this.bindingSource1;
            this.largePhotoPictureBox.DataBindings.Add("Image", this.bindingSource1, "LargePhoto", true);
            this.label3.DataBindings.Add("Text", this.bindingSource1, "ProductPhotoID");
        }
       
        private void FrmAW_Load(object sender, EventArgs e)
        {
            // 取得所有日期資料，並依序取出年份
            List<int> years = new List<int>();
            foreach (DataRow row in this.awDataSet1.ProductPhoto.Rows)
            {
                DateTime date = Convert.ToDateTime(row["ModifiedDate"]);
                int year = date.Year;

                // 如果該年份還沒加入選項，就加入
                if (!years.Contains(year))
                {
                    years.Add(year);
                }
            }
            years.Sort();//排序
            // 將年份選項填入 ComboBox
            foreach (int year in years)
            {                
                comboBox1.Items.Add(year.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            int year = int.Parse(comboBox1.SelectedItem.ToString());
            this.bindingSource1.Filter = string.Format("ModifiedDate >= #{0}/1/1# AND ModifiedDate < #{1}/1/1#", year, year + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startdate = dateTimePicker1.Value;
            DateTime enddate = dateTimePicker2.Value;
            //this.bindingSource1.Filter = string.Format("ModifiedDate >= #{0:M/d/yyyy}# AND ModifiedDate <= #{1:M/d/yyyy}#", startdate, enddate);            
            this.productPhotoTableAdapter1.FillByModifiedDate(this.awDataSet1.ProductPhoto, dateTimePicker1.Value, dateTimePicker2.Value);
        }        
    }
}
