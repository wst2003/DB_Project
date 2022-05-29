
namespace DB_project
{
    partial class ManagerLogin
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelPasssword = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(276, 109);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(34, 24);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // labelPasssword
            // 
            this.labelPasssword.AutoSize = true;
            this.labelPasssword.Location = new System.Drawing.Point(276, 191);
            this.labelPasssword.Name = "labelPasssword";
            this.labelPasssword.Size = new System.Drawing.Size(58, 24);
            this.labelPasssword.TabIndex = 0;
            this.labelPasssword.Text = "密码";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(442, 106);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(182, 35);
            this.textId.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(442, 188);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(182, 35);
            this.textPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(334, 283);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 79);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Checked = true;
            this.checkBoxShowPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowPwd.Location = new System.Drawing.Point(538, 283);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(138, 28);
            this.checkBoxShowPwd.TabIndex = 3;
            this.checkBoxShowPwd.Text = "显示密码";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 5.625F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(538, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "没有账号？去注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxShowPwd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelPasssword);
            this.Controls.Add(this.labelId);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPasssword;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPwd;
        private System.Windows.Forms.Button button1;
    }
}