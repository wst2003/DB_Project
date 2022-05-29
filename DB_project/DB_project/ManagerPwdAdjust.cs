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
    public partial class ManagerPwdAdjust : Form
    {
        public ManagerPwdAdjust()
        {
            InitializeComponent();
        }
        private void checkBoxShowPwd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                textOldPwd.UseSystemPasswordChar = false;
                textNewPwd.UseSystemPasswordChar = false;
                //textPassword.IsPasswordChat = default(char);
            }
            else
            {
                textOldPwd.UseSystemPasswordChar = true;
                textNewPwd.UseSystemPasswordChar = true;
            }
        }
        SqlConnection myConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True; MultipleActiveResultSets=true");
        private void btnConfirm_Click(object sender, EventArgs e)
        {
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
                    if (myreader.GetValue(0).ToString() == textId.Text && myreader.GetValue(2).ToString() == textOldPwd.Text)    //Manage表中有该ID/密码
                    {
                        flag = false;//标记有无账号重复
                        /*
                        string updatePwd = "Update Manager SET m_password = @NewPwd Where ID = @ID";


                        SqlCommand MyCommand = new SqlCommand(updatePwd, myConn); //定义一个数据库操作指令
                        */
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = myConn;
                        sqlCommand.CommandText = "Update Manager SET m_password = @NewPwd Where ID = @Id";
                        sqlCommand.Parameters.AddWithValue("@NewPwd", this.textNewPwd.Text);
                        sqlCommand.Parameters.AddWithValue("@Id", this.textId.Text);
                        sqlCommand.ExecuteNonQuery();
                        myConn.Close();//关闭数据库
                        myreader.Close();

                        MessageBox.Show("更新成功，请去登录界面登录");
                        this.Hide();
                        ManagerLogin frm = new ManagerLogin();
                        frm.Show();
                        break;
                        //跳出循环，不然会一直进行下去并报错
                    }
                    else
                    {
                        continue;
                    }
                }
                if (flag)//flag = true
                {
                    MessageBox.Show("请检查ID和原密码是否正确");
                    textOldPwd.Text = "";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin frm = new ManagerLogin();
            frm.Show();
        }
    }
}



            