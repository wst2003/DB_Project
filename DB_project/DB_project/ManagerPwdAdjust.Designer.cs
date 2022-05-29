
namespace DB_project
{
    partial class ManagerPwdAdjust
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbOldPwd = new System.Windows.Forms.Label();
            this.lbNewPwd = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textOldPwd = new System.Windows.Forms.TextBox();
            this.textNewPwd = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.checkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(299, 89);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(34, 24);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // lbOldPwd
            // 
            this.lbOldPwd.AutoSize = true;
            this.lbOldPwd.Location = new System.Drawing.Point(251, 161);
            this.lbOldPwd.Name = "lbOldPwd";
            this.lbOldPwd.Size = new System.Drawing.Size(82, 24);
            this.lbOldPwd.TabIndex = 0;
            this.lbOldPwd.Text = "原密码";
            // 
            // lbNewPwd
            // 
            this.lbNewPwd.AutoSize = true;
            this.lbNewPwd.Location = new System.Drawing.Point(251, 246);
            this.lbNewPwd.Name = "lbNewPwd";
            this.lbNewPwd.Size = new System.Drawing.Size(82, 24);
            this.lbNewPwd.TabIndex = 0;
            this.lbNewPwd.Text = "新密码";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(430, 89);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(157, 35);
            this.textId.TabIndex = 1;
            // 
            // textOldPwd
            // 
            this.textOldPwd.Location = new System.Drawing.Point(430, 161);
            this.textOldPwd.Name = "textOldPwd";
            this.textOldPwd.Size = new System.Drawing.Size(157, 35);
            this.textOldPwd.TabIndex = 1;
            // 
            // textNewPwd
            // 
            this.textNewPwd.Location = new System.Drawing.Point(430, 246);
            this.textNewPwd.Name = "textNewPwd";
            this.textNewPwd.Size = new System.Drawing.Size(157, 35);
            this.textNewPwd.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(289, 313);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(128, 56);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Checked = true;
            this.checkBoxShowPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowPwd.Location = new System.Drawing.Point(593, 313);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(138, 28);
            this.checkBoxShowPwd.TabIndex = 3;
            this.checkBoxShowPwd.Text = "显示密码";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(461, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 56);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerPwdAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkBoxShowPwd);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textNewPwd);
            this.Controls.Add(this.textOldPwd);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.lbNewPwd);
            this.Controls.Add(this.lbOldPwd);
            this.Controls.Add(this.lbId);
            this.Name = "ManagerPwdAdjust";
            this.Text = "ManagerPwdAdjust";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbOldPwd;
        private System.Windows.Forms.Label lbNewPwd;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textOldPwd;
        private System.Windows.Forms.TextBox textNewPwd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox checkBoxShowPwd;
        private System.Windows.Forms.Button btnExit;
    }
}