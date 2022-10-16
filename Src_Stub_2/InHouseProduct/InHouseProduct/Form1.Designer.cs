
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
            this.btnIsStarted = new System.Windows.Forms.Button();
            this.btnStartup = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTransaction1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTransaction2 = new System.Windows.Forms.Button();
            this.btnAllExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIsStarted
            // 
            this.btnIsStarted.Location = new System.Drawing.Point(385, 10);
            this.btnIsStarted.Name = "btnIsStarted";
            this.btnIsStarted.Size = new System.Drawing.Size(124, 23);
            this.btnIsStarted.TabIndex = 0;
            this.btnIsStarted.Text = "IsStarted";
            this.btnIsStarted.UseVisualStyleBackColor = true;
            this.btnIsStarted.Click += new System.EventHandler(this.btnIsStarted_Click);
            // 
            // btnStartup
            // 
            this.btnStartup.Location = new System.Drawing.Point(385, 40);
            this.btnStartup.Name = "btnStartup";
            this.btnStartup.Size = new System.Drawing.Size(124, 23);
            this.btnStartup.TabIndex = 3;
            this.btnStartup.Text = "Startup";
            this.btnStartup.UseVisualStyleBackColor = true;
            this.btnStartup.Click += new System.EventHandler(this.btnStartup_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(385, 136);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(124, 23);
            this.btnShutdown.TabIndex = 4;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Execute => ThirdPartyProducts / Initialize / IsStarted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Execute => ThirdPartyProducts / Initialize / Startup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Execute => ThirdPartyProducts / Initialize / Shutdown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Execute => ThirdPartyProducts / Initialize / Transaction1";
            // 
            // btnTransaction1
            // 
            this.btnTransaction1.Location = new System.Drawing.Point(385, 71);
            this.btnTransaction1.Name = "btnTransaction1";
            this.btnTransaction1.Size = new System.Drawing.Size(124, 23);
            this.btnTransaction1.TabIndex = 9;
            this.btnTransaction1.Text = "Transaction1";
            this.btnTransaction1.UseVisualStyleBackColor = true;
            this.btnTransaction1.Click += new System.EventHandler(this.btnTransaction1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Execute => ThirdPartyProducts / Initialize / Transaction2";
            // 
            // btnTransaction2
            // 
            this.btnTransaction2.Location = new System.Drawing.Point(385, 104);
            this.btnTransaction2.Name = "btnTransaction2";
            this.btnTransaction2.Size = new System.Drawing.Size(124, 23);
            this.btnTransaction2.TabIndex = 11;
            this.btnTransaction2.Text = "Transaction2";
            this.btnTransaction2.UseVisualStyleBackColor = true;
            this.btnTransaction2.Click += new System.EventHandler(this.btnTransaction2_Click);
            // 
            // btnAllExecute
            // 
            this.btnAllExecute.Location = new System.Drawing.Point(12, 184);
            this.btnAllExecute.Name = "btnAllExecute";
            this.btnAllExecute.Size = new System.Drawing.Size(191, 23);
            this.btnAllExecute.TabIndex = 13;
            this.btnAllExecute.Text = "All Execute";
            this.btnAllExecute.UseVisualStyleBackColor = true;
            this.btnAllExecute.Click += new System.EventHandler(this.btnAllExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 226);
            this.Controls.Add(this.btnAllExecute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTransaction2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransaction1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnStartup);
            this.Controls.Add(this.btnIsStarted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsStarted;
        private System.Windows.Forms.Button btnStartup;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTransaction1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTransaction2;
        private System.Windows.Forms.Button btnAllExecute;
    }
}
