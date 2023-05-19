using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.HomeWork
{
    public partial class FrmTravel : Form
    {
        public FrmTravel()
        {
            InitializeComponent();

            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.DragEnter += pictureBox1_DragEnter;
            this.flowLayoutPanel1.DragDrop += pictureBox1_DragDrop;

            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.DragEnter += pictureBox1_DragEnter;
            this.flowLayoutPanel2.DragDrop += pictureBox1_DragDrop;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            ;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
           ;
        }

        private void FrmTravel_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'travelDataSet.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.travelDataSet.Photos);
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Travel;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from PhotoCategory", conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox1.Items.Add(sqlDataReader[1]);
            }
            conn.Close();
        }
        class MyPhotoCategory
        {
            public int CategoryID;
            public string CategoryNmae;
            public override string ToString()
            {    return this.CategoryNmae;   }
        }        
          
        void p_MouseEnter(object sender,EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Gold;
        }

        void p_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Fuchsia;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
          
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void photosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void photosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }
    }
}
