namespace FileRead
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
            this.btn特定行読込み開始_ファイル = new System.Windows.Forms.Button();
            this.txt結果 = new System.Windows.Forms.TextBox();
            this.txt特定行に含まれる文字列 = new System.Windows.Forms.TextBox();
            this.txtファイル = new System.Windows.Forms.TextBox();
            this.rdo前方一致 = new System.Windows.Forms.RadioButton();
            this.rdo部分一致 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtフォルダ = new System.Windows.Forms.TextBox();
            this.btn特定行読込み開始_フォルダ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnクリア = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn特定行読込み開始_ファイル
            // 
            this.btn特定行読込み開始_ファイル.Location = new System.Drawing.Point(841, 87);
            this.btn特定行読込み開始_ファイル.Name = "btn特定行読込み開始_ファイル";
            this.btn特定行読込み開始_ファイル.Size = new System.Drawing.Size(166, 23);
            this.btn特定行読込み開始_ファイル.TabIndex = 4;
            this.btn特定行読込み開始_ファイル.Text = "特定行読込み開始(ファイル)";
            this.btn特定行読込み開始_ファイル.UseVisualStyleBackColor = true;
            this.btn特定行読込み開始_ファイル.Click += new System.EventHandler(this.btnファイル排他アクセス開始_Click_1);
            // 
            // txt結果
            // 
            this.txt結果.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt結果.BackColor = System.Drawing.Color.White;
            this.txt結果.Location = new System.Drawing.Point(3, 115);
            this.txt結果.Multiline = true;
            this.txt結果.Name = "txt結果";
            this.txt結果.ReadOnly = true;
            this.txt結果.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt結果.Size = new System.Drawing.Size(1022, 493);
            this.txt結果.TabIndex = 5;
            this.txt結果.WordWrap = false;
            // 
            // txt特定行に含まれる文字列
            // 
            this.txt特定行に含まれる文字列.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt特定行に含まれる文字列.Location = new System.Drawing.Point(7, 18);
            this.txt特定行に含まれる文字列.Name = "txt特定行に含まれる文字列";
            this.txt特定行に含まれる文字列.Size = new System.Drawing.Size(707, 19);
            this.txt特定行に含まれる文字列.TabIndex = 0;
            // 
            // txtファイル
            // 
            this.txtファイル.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtファイル.Location = new System.Drawing.Point(81, 89);
            this.txtファイル.Name = "txtファイル";
            this.txtファイル.Size = new System.Drawing.Size(754, 19);
            this.txtファイル.TabIndex = 3;
            this.txtファイル.Text = "C:\\Work\\orcl_ora_1733_1.aud";
            // 
            // rdo前方一致
            // 
            this.rdo前方一致.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo前方一致.AutoSize = true;
            this.rdo前方一致.Location = new System.Drawing.Point(730, 19);
            this.rdo前方一致.Name = "rdo前方一致";
            this.rdo前方一致.Size = new System.Drawing.Size(71, 16);
            this.rdo前方一致.TabIndex = 1;
            this.rdo前方一致.TabStop = true;
            this.rdo前方一致.Text = "前方一致";
            this.rdo前方一致.UseVisualStyleBackColor = true;
            // 
            // rdo部分一致
            // 
            this.rdo部分一致.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdo部分一致.AutoSize = true;
            this.rdo部分一致.Checked = true;
            this.rdo部分一致.Location = new System.Drawing.Point(807, 19);
            this.rdo部分一致.Name = "rdo部分一致";
            this.rdo部分一致.Size = new System.Drawing.Size(71, 16);
            this.rdo部分一致.TabIndex = 2;
            this.rdo部分一致.TabStop = true;
            this.rdo部分一致.Text = "部分一致";
            this.rdo部分一致.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ファイルパス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "フォルダパス";
            // 
            // txtフォルダ
            // 
            this.txtフォルダ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtフォルダ.Location = new System.Drawing.Point(81, 63);
            this.txtフォルダ.Name = "txtフォルダ";
            this.txtフォルダ.Size = new System.Drawing.Size(754, 19);
            this.txtフォルダ.TabIndex = 1;
            this.txtフォルダ.Text = "C:\\Work";
            // 
            // btn特定行読込み開始_フォルダ
            // 
            this.btn特定行読込み開始_フォルダ.Location = new System.Drawing.Point(841, 61);
            this.btn特定行読込み開始_フォルダ.Name = "btn特定行読込み開始_フォルダ";
            this.btn特定行読込み開始_フォルダ.Size = new System.Drawing.Size(166, 23);
            this.btn特定行読込み開始_フォルダ.TabIndex = 2;
            this.btn特定行読込み開始_フォルダ.Text = "特定行読込み開始(フォルダ)";
            this.btn特定行読込み開始_フォルダ.UseVisualStyleBackColor = true;
            this.btn特定行読込み開始_フォルダ.Click += new System.EventHandler(this.btn特定行読込み開始_フォルダ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnクリア);
            this.groupBox1.Controls.Add(this.txt特定行に含まれる文字列);
            this.groupBox1.Controls.Add(this.rdo前方一致);
            this.groupBox1.Controls.Add(this.rdo部分一致);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "抽出条件";
            // 
            // btnクリア
            // 
            this.btnクリア.Location = new System.Drawing.Point(915, 16);
            this.btnクリア.Name = "btnクリア";
            this.btnクリア.Size = new System.Drawing.Size(75, 23);
            this.btnクリア.TabIndex = 3;
            this.btnクリア.Text = "クリア";
            this.btnクリア.UseVisualStyleBackColor = true;
            this.btnクリア.Click += new System.EventHandler(this.btnクリア_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn特定行読込み開始_フォルダ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtフォルダ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt結果);
            this.Controls.Add(this.btn特定行読込み開始_ファイル);
            this.Controls.Add(this.txtファイル);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "特定行を抽出";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn特定行読込み開始_ファイル;
        private System.Windows.Forms.TextBox txt結果;
        private System.Windows.Forms.TextBox txt特定行に含まれる文字列;
        private System.Windows.Forms.TextBox txtファイル;
        private System.Windows.Forms.RadioButton rdo前方一致;
        private System.Windows.Forms.RadioButton rdo部分一致;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtフォルダ;
        private System.Windows.Forms.Button btn特定行読込み開始_フォルダ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnクリア;
    }
}

