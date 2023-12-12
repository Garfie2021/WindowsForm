namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnフォルダ選択 = new Button();
            btn削除 = new Button();
            label1 = new Label();
            txtDirectoryPath = new TextBox();
            dgbFolderList = new DataGridView();
            btn検索 = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            btn全選択 = new Button();
            btn全選択解除 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbFolderList).BeginInit();
            SuspendLayout();
            // 
            // btnフォルダ選択
            // 
            btnフォルダ選択.Location = new Point(701, 5);
            btnフォルダ選択.Name = "btnフォルダ選択";
            btnフォルダ選択.Size = new Size(94, 23);
            btnフォルダ選択.TabIndex = 0;
            btnフォルダ選択.Text = "フォルダ選択";
            btnフォルダ選択.UseVisualStyleBackColor = true;
            btnフォルダ選択.Click += btnフォルダ選択_Click;
            // 
            // btn削除
            // 
            btn削除.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn削除.Location = new Point(12, 415);
            btn削除.Name = "btn削除";
            btn削除.Size = new Size(75, 23);
            btn削除.TabIndex = 1;
            btn削除.Text = "削除";
            btn削除.UseVisualStyleBackColor = true;
            btn削除.Click += btn削除_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "対象フォルダ";
            // 
            // txtDirectoryPath
            // 
            txtDirectoryPath.Location = new Point(84, 5);
            txtDirectoryPath.Name = "txtDirectoryPath";
            txtDirectoryPath.Size = new Size(611, 23);
            txtDirectoryPath.TabIndex = 3;
            // 
            // dgbFolderList
            // 
            dgbFolderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgbFolderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbFolderList.Location = new Point(7, 63);
            dgbFolderList.Name = "dgbFolderList";
            dgbFolderList.RowTemplate.Height = 25;
            dgbFolderList.Size = new Size(944, 346);
            dgbFolderList.TabIndex = 4;
            // 
            // btn検索
            // 
            btn検索.Location = new Point(12, 34);
            btn検索.Name = "btn検索";
            btn検索.Size = new Size(191, 23);
            btn検索.TabIndex = 5;
            btn検索.Text = "bin/objフォルダをリストアップ";
            btn検索.UseVisualStyleBackColor = true;
            btn検索.Click += btnフォルダをリストアップ_Click;
            // 
            // btn全選択
            // 
            btn全選択.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn全選択.Location = new Point(98, 415);
            btn全選択.Name = "btn全選択";
            btn全選択.Size = new Size(75, 23);
            btn全選択.TabIndex = 6;
            btn全選択.Text = "全選択";
            btn全選択.UseVisualStyleBackColor = true;
            btn全選択.Click += btn全選択_Click;
            // 
            // btn全選択解除
            // 
            btn全選択解除.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn全選択解除.Location = new Point(179, 415);
            btn全選択解除.Name = "btn全選択解除";
            btn全選択解除.Size = new Size(75, 23);
            btn全選択解除.TabIndex = 7;
            btn全選択解除.Text = "全選択解除";
            btn全選択解除.UseVisualStyleBackColor = true;
            btn全選択解除.Click += btn全選択解除_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(btn全選択解除);
            Controls.Add(btn全選択);
            Controls.Add(btn検索);
            Controls.Add(dgbFolderList);
            Controls.Add(txtDirectoryPath);
            Controls.Add(label1);
            Controls.Add(btn削除);
            Controls.Add(btnフォルダ選択);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgbFolderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnフォルダ選択;
        private Button btn削除;
        private Label label1;
        private TextBox txtDirectoryPath;
        private DataGridView dgbFolderList;
        private Button btn検索;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btn全選択;
        private Button btn全選択解除;
    }
}