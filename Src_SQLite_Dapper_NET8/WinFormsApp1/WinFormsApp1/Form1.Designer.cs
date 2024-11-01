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
            btn追加 = new Button();
            dataGridView1 = new DataGridView();
            Clm編集 = new DataGridViewButtonColumn();
            Clm削除 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn追加
            // 
            btn追加.Location = new Point(12, 12);
            btn追加.Name = "btn追加";
            btn追加.Size = new Size(75, 23);
            btn追加.TabIndex = 0;
            btn追加.Text = "追加";
            btn追加.UseVisualStyleBackColor = true;
            btn追加.Click += btn追加_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Clm編集, Clm削除 });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Clm編集
            // 
            Clm編集.FillWeight = 50F;
            Clm編集.HeaderText = "";
            Clm編集.Name = "Clm編集";
            Clm編集.Text = "編集";
            Clm編集.UseColumnTextForButtonValue = true;
            Clm編集.Width = 50;
            // 
            // Clm削除
            // 
            Clm削除.HeaderText = "";
            Clm削除.Name = "Clm削除";
            Clm削除.Text = "削除";
            Clm削除.UseColumnTextForButtonValue = true;
            Clm削除.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn追加);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn追加;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Clm編集;
        private DataGridViewButtonColumn Clm削除;
    }
}
