namespace EventLogIssue
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtイベントID = new System.Windows.Forms.TextBox();
            this.txtソース = new System.Windows.Forms.TextBox();
            this.txt説明 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "発行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "イベントID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ソース";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "説明";
            // 
            // txtイベントID
            // 
            this.txtイベントID.Location = new System.Drawing.Point(69, 6);
            this.txtイベントID.Name = "txtイベントID";
            this.txtイベントID.Size = new System.Drawing.Size(211, 19);
            this.txtイベントID.TabIndex = 5;
            this.txtイベントID.Text = "34";
            // 
            // txtソース
            // 
            this.txtソース.Location = new System.Drawing.Point(69, 32);
            this.txtソース.Name = "txtソース";
            this.txtソース.Size = new System.Drawing.Size(211, 19);
            this.txtソース.TabIndex = 6;
            this.txtソース.Text = "Application";
            // 
            // txt説明
            // 
            this.txt説明.Location = new System.Drawing.Point(69, 60);
            this.txt説明.Name = "txt説明";
            this.txt説明.Size = new System.Drawing.Size(211, 19);
            this.txt説明.TabIndex = 7;
            this.txt説明.Text = "Application Log TEST2023";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 140);
            this.Controls.Add(this.txt説明);
            this.Controls.Add(this.txtソース);
            this.Controls.Add(this.txtイベントID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "イベントログ発行";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtイベントID;
        private System.Windows.Forms.TextBox txtソース;
        private System.Windows.Forms.TextBox txt説明;
    }
}

