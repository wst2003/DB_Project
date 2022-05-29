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
    public partial class ManagerOrders : Form
    {
        public ManagerOrders()
        {
            InitializeComponent();
        }
        //s_ID  c_ID c_num_s price ID 
        private void btnExamineAll_Click(object sender, EventArgs e)
        {
            SqlConnection MyConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True");
            SqlCommand MyCommand = new SqlCommand("SELECT c_ID, s_ID, c_num_s, price,ID FROM Orders", MyConn); //定义一个数据库操作指令
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
            DataSet MyDataSet = new DataSet();//定义一个数据集
            MyConn.Open();//打开数据库连接
            SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
            MyConn.Close();//关闭数据库
            SelectAdapter.Fill(MyDataSet, "st");//填充数据集
            dataGridView1.DataSource = MyDataSet.Tables["st"];
            dataGridView1.Columns[0].HeaderText = "买家ID";
            dataGridView1.Columns[1].HeaderText = "卖家ID";
            dataGridView1.Columns[2].HeaderText = "该买家在该卖家处订单序号";
            dataGridView1.Columns[3].HeaderText = "订单金额";
            dataGridView1.Columns[4].HeaderText = "管理员ID";

        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerManage frm = new ManagerManage();
            frm.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (textBuy.Text == "")
            {
                MessageBox.Show("请输入买家ID");
            }
            else
            {
                SqlConnection MyConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = MyConn;
                sqlCommand.CommandText = "SELECT c_ID,s_ID,  c_num_s, price,ID FROM Orders  WHERE c_ID=@c_ID";
                sqlCommand.Parameters.AddWithValue("@c_Id", this.textBuy.Text);

                SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
                SelectAdapter.SelectCommand = sqlCommand;//定义数据适配器的操作指令
                DataSet MyDataSet = new DataSet();//定义一个数据集
                MyConn.Open();//打开数据库连接
                SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
                MyConn.Close();//关闭数据库
                SelectAdapter.Fill(MyDataSet, "st");//填充数据集
                dataGridView1.DataSource = MyDataSet.Tables["st"];
                dataGridView1.Columns[0].HeaderText = "买家ID";
                dataGridView1.Columns[1].HeaderText = "卖家ID";
                dataGridView1.Columns[2].HeaderText = "该买家在该卖家处订单序号";
                dataGridView1.Columns[3].HeaderText = "订单金额";
                dataGridView1.Columns[4].HeaderText = "管理员ID";
            }
        }
        private void btnSold_Click(object sender, EventArgs e)
        {
            if (textBuy.Text == "")
            {
                MessageBox.Show("请先输入买家ID");
            }
            else
            {
                if (textSold.Text == "")
                {
                    MessageBox.Show("请输入卖家ID");
                }
                else
                {
                    SqlConnection MyConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True");
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = MyConn;
                    sqlCommand.CommandText = "SELECT c_ID, s_ID, c_num_s, price,ID FROM Orders  WHERE s_ID = @s_Id And c_ID=@c_Id";
                    sqlCommand.Parameters.AddWithValue("@s_Id", this.textSold.Text);
                    sqlCommand.Parameters.AddWithValue("@c_Id", this.textBuy.Text);

                    SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
                    SelectAdapter.SelectCommand = sqlCommand;//定义数据适配器的操作指令
                    DataSet MyDataSet = new DataSet();//定义一个数据集
                    MyConn.Open();//打开数据库连接
                    SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
                    MyConn.Close();//关闭数据库
                    SelectAdapter.Fill(MyDataSet, "st");//填充数据集
                    dataGridView1.DataSource = MyDataSet.Tables["st"];
                    dataGridView1.Columns[0].HeaderText = "买家ID";
                    dataGridView1.Columns[1].HeaderText = "卖家ID";
                    dataGridView1.Columns[2].HeaderText = "该买家在该卖家处订单序号";
                    dataGridView1.Columns[3].HeaderText = "订单金额";
                    dataGridView1.Columns[4].HeaderText = "管理员ID";
                }
            }
        }
    }
}
