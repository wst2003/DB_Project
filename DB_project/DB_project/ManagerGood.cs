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
using System.IO;

namespace DB_project
{
    public partial class ManagerGood : Form
    {
        public ManagerGood()
        {
            InitializeComponent();
        }
        SqlConnection MyConn = new SqlConnection("Data Source = LAPTOP-29GATT3G\\DATA; Initial Catalog = project; Integrated Security = True");

        private void btnExamineAll_Click(object sender, EventArgs e)
        {
            SqlCommand MyCommand = new SqlCommand("SELECT ID, name, amounts, specie,singlePrice,soldAmounts,createdate FROM Good", MyConn); //定义一个数据库操作指令
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
            DataSet MyDataSet = new DataSet();//定义一个数据集
            MyConn.Open();//打开数据库连接
            SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
            MyConn.Close();//关闭数据库
            SelectAdapter.Fill(MyDataSet, "st");//填充数据集
            dataGridView1.DataSource = MyDataSet.Tables["st"];
            dataGridView1.Columns[0].HeaderText = "物品ID";
            dataGridView1.Columns[1].HeaderText = "物品名称";
            dataGridView1.Columns[2].HeaderText = "物品数量";
            dataGridView1.Columns[3].HeaderText = "物品种类";
            dataGridView1.Columns[4].HeaderText = "物品单价";
            dataGridView1.Columns[5].HeaderText = "物品售出数量";
            dataGridView1.Columns[6].HeaderText = "物品创建日期";
            //dataGridView1.Columns[7].HeaderText = "物品图片";

            pictureBox1.Image = null;
            /*
            foreach (DataRow row in MyDataSet.Tables["st"].Rows)
            {
                if (File.Exists(row["picture_URL"].ToString()))
                {
                    Image img = Image.FromFile(row["picture_URL"].ToString());
                    row["picture_URL"] = img;
                    
                }
            }

            for (int i = 0; i < MyDataSet.Tables["st"].Rows.Count; i++)

            {
                //下面两个方式都可以

                //dataGridView1.Rows[i].Cells["picture_URL"].Value = new Bitmap(MyDataSet.Tables["st"].Rows[i].ItemArray[7].ToString());

                dataGridView1.Rows[i].Cells["picture_URL"].Value = Image.FromFile(MyDataSet.Tables["st"].Rows[i]["picture_URL"].ToString().Trim());

            }
            */
        }

        private void btnExamineBy_Click(object sender, EventArgs e)
        {
            //select score from sc where snum = '{comboBox1.Text}' and secnum = '{comboBox2.Text}'
            if (textId.Text == "")
            {
                MessageBox.Show("请输入物品ID");
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = MyConn;
                sqlCommand.CommandText = "SELECT ID, name, amounts, specie,singlePrice,soldAmounts,createdate,picture_URL FROM Good WHERE ID = @Id" ;
                sqlCommand.Parameters.AddWithValue("@Id", this.textId.Text);
                //sqlCommand.ExecuteNonQuery();

                //SqlCommand MyCommand = new SqlCommand("SELECT ID, name, amounts, specie,singlePrice,soldAmounts,createdate,picture_URL FROM Good WHERE ID= '{textId.Text}'", MyConn); //定义一个数据库操作指令
                SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
                SelectAdapter.SelectCommand = sqlCommand;//定义数据适配器的操作指令
                DataSet MyDataSet = new DataSet();//定义一个数据集
                MyConn.Open();//打开数据库连接
                SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
                MyConn.Close();//关闭数据库
                SelectAdapter.Fill(MyDataSet, "st1");//填充数据集
                dataGridView1.DataSource = MyDataSet.Tables["st1"];
                dataGridView1.Columns[0].HeaderText = "物品ID";
                dataGridView1.Columns[1].HeaderText = "物品名称";
                dataGridView1.Columns[2].HeaderText = "物品数量";
                dataGridView1.Columns[3].HeaderText = "物品种类";
                dataGridView1.Columns[4].HeaderText = "物品单价";
                dataGridView1.Columns[5].HeaderText = "物品售出数量";
                dataGridView1.Columns[6].HeaderText = "物品创建日期";
                dataGridView1.Columns[7].HeaderText = "物品图片";

                this.pictureBox1.Load(MyDataSet.Tables["st1"].Rows[0].ItemArray[7].ToString());
                //pictureBox1.Location = new System.Drawing.Point(140, 25);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Size = new System.Drawing.Size(240, 240);
                pictureBox1.TabIndex = 4;
                System.Drawing.Image image = System.Drawing.Image.FromFile(MyDataSet.Tables["st1"].Rows[0].ItemArray[7].ToString());
                pictureBox1.Image = image;
            }
        }

        private void btnDeletee_Click(object sender, EventArgs e)
        {
            string MyDelete = "Delete from Good where ID = " + this.dataGridView1.CurrentRow.Cells["ID"].Value + "";
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            SqlCommand MyCommand = new SqlCommand(MyDelete, MyConn);
            try
            {
                MyConn.Open();
                MyCommand.ExecuteNonQuery();
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerManage frm = new ManagerManage();
            frm.Show();
        }
    }
}


