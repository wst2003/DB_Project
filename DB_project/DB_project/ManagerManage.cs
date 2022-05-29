using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class ManagerManage : Form
    {
        public ManagerManage()
        {
            InitializeComponent();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerOrders frm = new ManagerOrders();
            frm.Show();
        }

        private void 物品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerGood frm = new ManagerGood();
            frm.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerPwdAdjust frm = new ManagerPwdAdjust();
            frm.Show();
        }
    }
}


