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
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
                //textPassword.IsPasswordChat = default(char);
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True; MultipleActiveResultSets=true");
            string mysql1 = "select * from Student";
            string mysql2 = "insert into Student values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
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
                    myCmd2.CommandText = String.Format(mysql2, textId.Text,textName.Text, textPassword.Text, DateTime.Now.ToString("yyyy-MM-dd"), textMoney.Text,textBuilding.Text, textRoom.Text,textSex.Text, textTelephone.Text);
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
