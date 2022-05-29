
namespace DB_project
{
    partial class ManagerOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExamineAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.textBuy = new System.Windows.Forms.ToolStripTextBox();
            this.btnSold = new System.Windows.Forms.ToolStripMenuItem();
            this.textSold = new System.Windows.Forms.ToolStripTextBox();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExamineAll,
            this.btnBuy,
            this.textBuy,
            this.btnSold,
            this.textSold,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExamineAll
            // 
            this.btnExamineAll.Name = "btnExamineAll";
            this.btnExamineAll.Size = new System.Drawing.Size(130, 38);
            this.btnExamineAll.Text = "查询全部";
            this.btnExamineAll.Click += new System.EventHandler(this.btnExamineAll_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(154, 38);
            this.btnBuy.Text = "依买家查询";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // textBuy
            // 
            this.textBuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.textBuy.Name = "textBuy";
            this.textBuy.Size = new System.Drawing.Size(100, 38);
            // 
            // btnSold
            // 
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(154, 38);
            this.btnSold.Text = "依卖家查询";
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // textSold
            // 
            this.textSold.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.textSold.Name = "textSold";
            this.textSold.Size = new System.Drawing.Size(100, 38);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 38);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // ManagerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerOrders";
            this.Text = "ManagerOrders";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem btnExamineAll;
        private System.Windows.Forms.ToolStripMenuItem btnSold;
        private System.Windows.Forms.ToolStripTextBox textSold;
        private System.Windows.Forms.ToolStripMenuItem btnBuy;
        private System.Windows.Forms.ToolStripTextBox textBuy;
    }
}