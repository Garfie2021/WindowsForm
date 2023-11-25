namespace WinFormsApp1
{
    partial class Form2
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
            textReportNo = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textDescription = new TextBox();
            label4 = new Label();
            textTitle = new TextBox();
            label3 = new Label();
            textDate = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            textDetail3 = new TextBox();
            label7 = new Label();
            textDetail2 = new TextBox();
            label6 = new Label();
            textDetail1 = new TextBox();
            label1 = new Label();
            textNumberOfLines = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textReportNo
            // 
            textReportNo.Location = new Point(85, 22);
            textReportNo.Name = "textReportNo";
            textReportNo.Size = new Size(253, 23);
            textReportNo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Viewer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textDescription);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textTitle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textReportNo);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 252);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Header";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 112);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 8;
            label5.Text = "Description : ";
            // 
            // textDescription
            // 
            textDescription.Location = new Point(85, 109);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(253, 122);
            textDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Title : ";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(85, 80);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(253, 23);
            textTitle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Date : ";
            // 
            // textDate
            // 
            textDate.Location = new Point(85, 51);
            textDate.Name = "textDate";
            textDate.Size = new Size(253, 23);
            textDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "ReportNo : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textDetail3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textDetail2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textDetail1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textNumberOfLines);
            groupBox2.Location = new Point(12, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 106);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 25);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 7;
            label8.Text = "Detail 3 : ";
            // 
            // textDetail3
            // 
            textDetail3.Location = new Point(447, 22);
            textDetail3.Name = "textDetail3";
            textDetail3.Size = new Size(109, 23);
            textDetail3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 25);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 5;
            label7.Text = "Detail 2 : ";
            // 
            // textDetail2
            // 
            textDetail2.Location = new Point(251, 22);
            textDetail2.Name = "textDetail2";
            textDetail2.Size = new Size(109, 23);
            textDetail2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 3;
            label6.Text = "Detail 1 : ";
            // 
            // textDetail1
            // 
            textDetail1.Location = new Point(63, 22);
            textDetail1.Name = "textDetail1";
            textDetail1.Size = new Size(109, 23);
            textDetail1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Number of lines : ";
            // 
            // textNumberOfLines
            // 
            textNumberOfLines.Location = new Point(110, 60);
            textNumberOfLines.Name = "textNumberOfLines";
            textNumberOfLines.Size = new Size(62, 23);
            textNumberOfLines.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(97, 390);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "PDF";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 426);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textReportNo;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textNumberOfLines;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textTitle;
        private Label label3;
        private TextBox textDate;
        private Label label5;
        private TextBox textDescription;
        private Label label6;
        private TextBox textDetail1;
        private Label label8;
        private TextBox textDetail3;
        private Label label7;
        private TextBox textDetail2;
        private Button button2;
    }
}