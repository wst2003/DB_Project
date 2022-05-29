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
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                textPwd.UseSystemPasswordChar = false;
                //textPassword.IsPasswordChat = default(char);
            }
            else
            {
                textPwd.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True; MultipleActiveResultSets=true");
            string mysql = "select * from Student";
            bool flag = true;

            try
            {
                SqlCommand myCmd = new SqlCommand(mysql, myConn);
                SqlDataReader myreader;
                myConn.Open();
                myreader = myCmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (myreader.GetValue(0).ToString() == textId.Text && myreader.GetValue(2).ToString() == textPwd.Text)    //Manage表中有该ID/密码
                    {
                        MessageBox.Show("登陆成功");
                        flag = false;//标记有无账号重复
                    }
                }
                if (flag)//flag = true
                {
                    MessageBox.Show("请检查ID和密码是否正确");
                    textPwd.Text = "";
                }
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
