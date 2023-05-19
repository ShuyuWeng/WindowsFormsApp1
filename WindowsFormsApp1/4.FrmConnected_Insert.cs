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
using System.Configuration;
using xxxx;

namespace WindowsFormsApp1
{
    public partial class FrmConnected_Insert : Form
    {
        public FrmConnected_Insert()
        {
            InitializeComponent();
            this.tabControl1.SelectedIndex = 1;
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += pictureBox1_DragEnter;
            this.pictureBox1.DragDrop += pictureBox1_DragDrop;

            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.DragEnter += pictureBox1_DragEnter;
            this.flowLayoutPanel1.DragDrop += pictureBox1_DragDrop;
        }
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            //MessageBox.Show("Drag Drop");
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBox1.Image = Image.FromFile(files[0]);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                         
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    string UserName = this.textBox1.Text;
                    string Password = this.textBox2.Text;
                    SqlCommand command = new SqlCommand();
                    //command.CommandText = "Insert into MyMember(UserID,Password) values('xxx','xxx')";
                    command.CommandText = $"Insert into MyMember(UserName,Password)values('{UserName}', '{Password}')";

                    command.Connection = conn;
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert Command successfully");

                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    string UserName = this.textBox1.Text;
                    string Password = this.textBox2.Text;
                    SqlCommand command = new SqlCommand();
                    
                    command.CommandText = $"select*from MyMember where UserName='{UserName}'and Password='{Password}'";

                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("LogOn Command successfully");
                    }
                    else
                    {
                        MessageBox.Show("LogOn Member Failed");
                    }                    

                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    string UserName = this.textBox1.Text;
                    //string Password = this.textBox2.Text;
                    //用web緊湊值密碼加密
                    string Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.textBox2.Text, "sha1");
                   
                    SqlCommand command = new SqlCommand();
                    //command.CommandText = "Insert into MyMember(UserID,Password) values('xxx','xxx')";
                    //command.CommandText = $"Insert into MyMember(UserName,Password)values('{UserName}', '{Password}')";
                    command.CommandText = $"Insert into MyMember(UserName,Password)values(@UserName, @Password)";
                    command.Parameters.Add("@UserName",SqlDbType.NVarChar,16).Value=UserName;
                    command.Parameters.Add("@Password",SqlDbType.NVarChar,40).Value=Password;
                    command.Connection = conn;
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert Command successfully");

                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    string UserName = this.textBox1.Text;
                    //string Password = this.textBox2.Text;
                    //用web緊湊值密碼加密
                    string Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.textBox2.Text, "sha1");
                    
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select*from MyMember where UserName=@UserName and Password= @Password";
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("LogOn Command successfully");
                    }
                    else
                    {
                        MessageBox.Show("LogOn Member Failed");
                    }
                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;

                    SqlCommand command = new SqlCommand();

                    command.CommandText = $"Insert into MyImage (Description,Image)values(@Description, @Image)";

                    byte[] bytes;// = {1,3 }; //圖片是二進位，要用byte
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();
                    command.Parameters.Add("@Description", SqlDbType.NText).Value = this.textBox3.Text;
                    command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = bytes;
                    command.Connection = conn;

                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert Image Command successfully");

                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select * from MyImage";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    this.listBox2.Items.Clear();
                    while (dataReader.Read())
                    {
                        this.listBox1.Items.Add(dataReader["Description"]);
                        this.listBox2.Items.Add(dataReader["Id"]);
                    }

                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select coommand
            int ImageID = (int)this.listBox2.Items[this.listBox1.SelectedIndex];//listbox2顯示listbox1選擇的索引值
            ShowImage(ImageID);
        }

        private void ShowImage(int ImageID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select * from MyImage where Id =" + ImageID;
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();
                    //==================================
                    byte[] bytes = (byte[])dataReader["Image"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);

                    this.pictureBox2.Image = Image.FromStream(ms);
                    //==========================

                }//auto conn.close
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.pictureBox2.Image = this.pictureBox2.ErrorImage;
            }
        }
                

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select * from MyImage";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox3.Items.Clear();
                    while (dataReader.Read())
                    {
                        xxxx.MyImage myImage = new xxxx.MyImage();
                        myImage.ImageID = (int)dataReader["Id"];
                        myImage.ImageDesc = dataReader["Description"].ToString();
                        this.listBox3.Items.Add(myImage);
                    }
                }//auto conn.close
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select coommand
            int ImageID = ((MyImage)this.listBox3.SelectedItem).ImageID;
            //int ImageID = ((MyImage)this.listBox3.Items[this.listBox3.SelectedIndex]).ImageID;
            ShowImage(ImageID);
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Click += Pic_Click;

                pic.Width = 120;
                pic.Height = 120;

                this.flowLayoutPanel1.Controls.Add(pic);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Show();
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connString = ConfigurationManager
                                                         .ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;

                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;

                    command.CommandText = "select Max (UnitPrice) from products";
                    MessageBox.Show($"Max UnitPrice = {command.ExecuteScalar():c2}");

                } //Auto Conn.Close();=> Conn.Dispose() 釋放 System.ComponentModel.Component 所使用的所有資源。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

namespace xxxx
{
    public class MyImage : Object // Object萬物之母
    {
        public int ImageID { get; set; }
        public string ImageDesc { get; set; }

        public override string ToString()
        {
            return $"{this.ImageID}************{this.ImageDesc}";
        }

    }
}
