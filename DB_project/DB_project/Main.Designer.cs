namespace DB_project
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ManagerLogin = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.sellersCheckButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.customerCheckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(408, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎来到以物“济”物交易平台！";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("宋体", 15F);
            this.RegisterButton.Location = new System.Drawing.Point(1434, 695);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(148, 61);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "注册";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("宋体", 15F);
            this.LoginButton.Location = new System.Drawing.Point(1434, 797);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(148, 61);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // ManagerLogin
            // 
            this.ManagerLogin.Font = new System.Drawing.Font("宋体", 12F);
            this.ManagerLogin.Location = new System.Drawing.Point(36, 797);
            this.ManagerLogin.Name = "ManagerLogin";
            this.ManagerLogin.Size = new System.Drawing.Size(148, 61);
            this.ManagerLogin.TabIndex = 3;
            this.ManagerLogin.Text = "管理员通道";
            this.ManagerLogin.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("宋体", 15F);
            this.sellButton.Location = new System.Drawing.Point(366, 260);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(167, 85);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "我要卖货";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // sellersCheckButton
            // 
            this.sellersCheckButton.Font = new System.Drawing.Font("宋体", 15F);
            this.sellersCheckButton.Location = new System.Drawing.Point(366, 440);
            this.sellersCheckButton.Name = "sellersCheckButton";
            this.sellersCheckButton.Size = new System.Drawing.Size(167, 85);
            this.sellersCheckButton.TabIndex = 5;
            this.sellersCheckButton.Text = "我的铺子";
            this.sellersCheckButton.UseVisualStyleBackColor = true;
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("宋体", 15F);
            this.buyButton.Location = new System.Drawing.Point(1116, 260);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(167, 85);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "我要买货";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // customerCheckButton
            // 
            this.customerCheckButton.Font = new System.Drawing.Font("宋体", 15F);
            this.customerCheckButton.Location = new System.Drawing.Point(1116, 455);
            this.customerCheckButton.Name = "customerCheckButton";
            this.customerCheckButton.Size = new System.Drawing.Size(167, 85);
            this.customerCheckButton.TabIndex = 6;
            this.customerCheckButton.Text = "我的宝贝";
            this.customerCheckButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 896);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.customerCheckButton);
            this.Controls.Add(this.sellersCheckButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.ManagerLogin);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "以物“济”物交易平台";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ManagerLogin;
        private System.Windows.Forms.Button sellButton;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button customerCheckButton;
        private System.Windows.Forms.Button sellersCheckButton;
    }
}

