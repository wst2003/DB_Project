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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True; MultipleActiveResultSets=true");
            string mysql = "select * from Manager";
            bool flag = true;

            try
            {
                SqlCommand myCmd = new SqlCommand(mysql, myConn);
                SqlDataReader myreader;
                myConn.Open();
                myreader = myCmd.ExecuteReader();

                while (myreader.Read())
                {
                    if (myreader.GetValue(0).ToString() == textId.Text && myreader.GetValue(2).ToString() == textPassword.Text)    //Manage表中有该ID/密码
                    {
                        MessageBox.Show("登陆成功");
                        flag = false;//标记有无账号重复
                        this.Hide();
                        ManagerManage frm = new ManagerManage();
                        frm.Show();
                    }
                }
                if (flag)//flag = true
                {
                    MessageBox.Show("请检查ID和密码是否正确");
                    textPassword.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerRegister managerRegister = new ManagerRegister();
            managerRegister.Show();
            this.Hide();
        }
    }
}
