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

namespace DB_project
{
    public partial class ManagerRegister : Form
    {
        public ManagerRegister()
        {
            InitializeComponent();
        }


        private void checkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
                //textPassword.IsPasswordChat = default(char);
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }

        }

        

        private bool IsNumber(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            textId.MaxLength = 4;
            if (IsNumber(textId.Text.Trim()) == false || textId.Text.Length != 4)
            {
                MessageBox.Show("请重新输入由4位数字组成的ID");
                textId.Text = "";
                textPassword.Text = "";
                textName.Text = "";
            }
            else
            {

                SqlConnection myConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True; MultipleActiveResultSets=true");
                string mysql1 = "select * from Manager";
                string mysql2 = "insert into Manager values('{0}','{1}','{2}','{3}')";
                bool flag = true;
                try
                {
                    SqlCommand myCmd1 = new SqlCommand(mysql1, myConn);
                    SqlDataReader myreader1;
                    myConn.Open();
                    myreader1 = myCmd1.ExecuteReader();

                    while (myreader1.Read())
                    {
                        if (myreader1.GetValue(0).ToString() == textId.Text)    //manage表中有该学号/工号
                        {
                            MessageBox.Show("该账号已被注册，请重新输入账号！");
                            flag = false;//标记有无账号重复
                        }
                    }
                    if (flag)//flag = true无账号重复，可以注册
                    {
                        myreader1.Close();
                        SqlCommand myCmd2 = myConn.CreateCommand();
                        SqlDataReader myreader2;
                        myreader2 = myCmd1.ExecuteReader();
                        myCmd2.CommandText = String.Format(mysql2, textId.Text, textName.Text, textPassword.Text, DateTime.Now.ToString("yyyy-MM-dd"));
                        myreader2 = myCmd2.ExecuteReader();
                        MessageBox.Show("账号注册成功！请到登录界面进行登录");
                        ManagerLogin frm = new ManagerLogin();
                        frm.Show();
                        this.Hide();
                    }
                    //else
                    //   MessageBox.Show("读取数据失败！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    myConn.Close();
                }
            }

        }

    }
}


