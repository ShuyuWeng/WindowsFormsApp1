using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.HomeWork
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    string UserName = this.UsernameTextBox.Text;
                    //string Password = this.textBox2.Text;
                    //用web緊湊值密碼加密
                    string Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.PasswordTextBox.Text, "sha1");

                    SqlCommand command = new SqlCommand();
                    //command.CommandText = "Insert into MyMember(UserID,Password) values('xxx','xxx')";
                    //command.CommandText = $"Insert into MyMember(UserName,Password)values('{UserName}', '{Password}')";
                    command.CommandText = $"Insert into MyMember(UserName,Password)values(@UserName, @Password)";
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;
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
        private int loginAttempts = 0; // 新增一个计数器，记录输入密码错误的次数
        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.NorthwindConnectionString"].ConnectionString;
                    conn.ConnectionString = connstring;
                    string UserName = this.UsernameTextBox.Text;
                    string Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.PasswordTextBox.Text, "sha1");

                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select * From MyMember where UserName=@UserName";
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = @UserName;
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string dbPassword = dataReader["Password"].ToString();                            
                            if (Password == dbPassword)
                            {
                                MessageBox.Show("Password Command successfully.");
                                loginAttempts = 0; // 錯誤計數器歸零
                            }
                            else
                            {
                                loginAttempts++;
                                if (loginAttempts >= 3)
                                {
                                    MessageBox.Show("密碼輸入錯誤超過3次，請重新設定密碼。");
                                }
                                else
                                {
                                    MessageBox.Show("Password is Failed。");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
