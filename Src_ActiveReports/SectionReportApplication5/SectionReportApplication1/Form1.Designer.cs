namespace SectionReportApplication1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.viewer1 = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
            this.SuspendLayout();
            // 
            // viewer1
            // 
            this.viewer1.AnnotationDropDownVisible = false;
            this.viewer1.CurrentPage = 0;
            this.viewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer1.HyperlinkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewer1.HyperlinkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.viewer1.Location = new System.Drawing.Point(0, 0);
            this.viewer1.Name = "viewer1";
            this.viewer1.PagesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewer1.PreviewPages = 0;
            this.viewer1.SearchResultsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.viewer1.SearchResultsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            this.viewer1.Size = new System.Drawing.Size(644, 398);
            this.viewer1.SplitView = false;
            this.viewer1.TabIndex = 0;
            this.viewer1.ViewType = GrapeCity.Viewer.Common.Model.ViewType.SinglePage;
            this.viewer1.Zoom = 1F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 398);
            this.Controls.Add(this.viewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.ActiveReports.Viewer.Win.Viewer viewer1;
    }
}

