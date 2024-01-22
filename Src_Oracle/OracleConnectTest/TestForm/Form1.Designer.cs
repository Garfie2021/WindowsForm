namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.InstanceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RacServiceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OraclePortNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OracleUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OraclePW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.cmbDBAPrivilege = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(16, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "接続テスト";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ServerName";
            // 
            // ServerName
            // 
            this.ServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerName.Location = new System.Drawing.Point(139, 37);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(231, 19);
            this.ServerName.TabIndex = 2;
            this.ServerName.Text = "localhost";
            // 
            // InstanceName
            // 
            this.InstanceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstanceName.Location = new System.Drawing.Point(139, 62);
            this.InstanceName.Name = "InstanceName";
            this.InstanceName.Size = new System.Drawing.Size(231, 19);
            this.InstanceName.TabIndex = 4;
            this.InstanceName.Text = "ORCL1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instance Name";
            // 
            // RacServiceName
            // 
            this.RacServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RacServiceName.Location = new System.Drawing.Point(139, 87);
            this.RacServiceName.Name = "RacServiceName";
            this.RacServiceName.Size = new System.Drawing.Size(231, 19);
            this.RacServiceName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rac Service Name";
            // 
            // OraclePortNo
            // 
            this.OraclePortNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OraclePortNo.Location = new System.Drawing.Point(139, 112);
            this.OraclePortNo.Name = "OraclePortNo";
            this.OraclePortNo.Size = new System.Drawing.Size(231, 19);
            this.OraclePortNo.TabIndex = 8;
            this.OraclePortNo.Text = "1521";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oracle Port No";
            // 
            // OracleUser
            // 
            this.OracleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OracleUser.Location = new System.Drawing.Point(139, 139);
            this.OracleUser.Name = "OracleUser";
            this.OracleUser.Size = new System.Drawing.Size(231, 19);
            this.OracleUser.TabIndex = 10;
            this.OracleUser.Text = "TEST_USER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Oracle User";
            // 
            // OraclePW
            // 
            this.OraclePW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OraclePW.Location = new System.Drawing.Point(139, 164);
            this.OraclePW.Name = "OraclePW";
            this.OraclePW.PasswordChar = '*';
            this.OraclePW.Size = new System.Drawing.Size(231, 19);
            this.OraclePW.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Oracle Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "DB Connction Driver";
            // 
            // cmbServerName
            // 
            this.cmbServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Items.AddRange(new object[] {
            "ODAC",
            "OLEDB",
            "ODBC"});
            this.cmbServerName.Location = new System.Drawing.Point(139, 11);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(113, 20);
            this.cmbServerName.TabIndex = 14;
            // 
            // cmbDBAPrivilege
            // 
            this.cmbDBAPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDBAPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDBAPrivilege.FormattingEnabled = true;
            this.cmbDBAPrivilege.Items.AddRange(new object[] {
            "SYSDBA",
            "SYSOPER"});
            this.cmbDBAPrivilege.Location = new System.Drawing.Point(139, 189);
            this.cmbDBAPrivilege.Name = "cmbDBAPrivilege";
            this.cmbDBAPrivilege.Size = new System.Drawing.Size(113, 20);
            this.cmbDBAPrivilege.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "DBA Privilege";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 270);
            this.Controls.Add(this.cmbDBAPrivilege);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbServerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OraclePW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OracleUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OraclePortNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RacServiceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InstanceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle接続テスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.TextBox InstanceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RacServiceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OraclePortNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OracleUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OraclePW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.ComboBox cmbDBAPrivilege;
        private System.Windows.Forms.Label label8;
    }
}

