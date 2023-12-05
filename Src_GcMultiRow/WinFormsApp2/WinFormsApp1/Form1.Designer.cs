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
            GcMultiRow1 = new GrapeCity.Win.MultiRow.GcMultiRow();
            ((System.ComponentModel.ISupportInitialize)GcMultiRow1).BeginInit();
            SuspendLayout();
            // 
            // GcMultiRow1
            // 
            GcMultiRow1.Location = new Point(12, 12);
            GcMultiRow1.Name = "GcMultiRow1";
            GcMultiRow1.Size = new Size(776, 426);
            GcMultiRow1.TabIndex = 0;
            GcMultiRow1.Text = "gcMultiRow1";
            GcMultiRow1.CellClick += GcMultiRow1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GcMultiRow1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GcMultiRow1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GrapeCity.Win.MultiRow.GcMultiRow GcMultiRow1;
    }
}