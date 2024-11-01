namespace WinFormsApp1
{
    partial class FormEdit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEnd = new TextBox();
            txtStart = new TextBox();
            btn登録 = new Button();
            btnキャンセル = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 75);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 105);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 10);
            txtId.Name = "txtId";
            txtId.Size = new Size(159, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(159, 23);
            txtName.TabIndex = 5;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(79, 71);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(159, 23);
            txtEnd.TabIndex = 6;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(79, 40);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(159, 23);
            txtStart.TabIndex = 7;
            // 
            // btn登録
            // 
            btn登録.Location = new Point(25, 154);
            btn登録.Name = "btn登録";
            btn登録.Size = new Size(75, 23);
            btn登録.TabIndex = 8;
            btn登録.Text = "登録";
            btn登録.UseVisualStyleBackColor = true;
            btn登録.Click += btn登録_Click;
            // 
            // btnキャンセル
            // 
            btnキャンセル.Location = new Point(138, 154);
            btnキャンセル.Name = "btnキャンセル";
            btnキャンセル.Size = new Size(75, 23);
            btnキャンセル.TabIndex = 9;
            btnキャンセル.Text = "キャンセル";
            btnキャンセル.UseVisualStyleBackColor = true;
            btnキャンセル.Click += btnキャンセル_Click;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 191);
            Controls.Add(btnキャンセル);
            Controls.Add(btn登録);
            Controls.Add(txtStart);
            Controls.Add(txtEnd);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEdit";
            Text = "編集";
            Load += FormEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtEnd;
        private TextBox txtStart;
        private Button btn登録;
        private Button btnキャンセル;
    }
}
