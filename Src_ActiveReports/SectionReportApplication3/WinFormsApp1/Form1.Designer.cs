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
            viewer1 = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
            SuspendLayout();
            // 
            // viewer1
            // 
            viewer1.CurrentPage = 0;
            viewer1.Location = new Point(1, 0);
            viewer1.Name = "viewer1";
            viewer1.PreviewPages = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            viewer1.Sidebar.ParametersPanel.ContextMenu = null;
            viewer1.Sidebar.ParametersPanel.Text = "パラメータ";
            viewer1.Sidebar.ParametersPanel.Width = 200;
            // 
            // 
            // 
            viewer1.Sidebar.SearchPanel.ContextMenu = null;
            viewer1.Sidebar.SearchPanel.Text = "検索";
            viewer1.Sidebar.SearchPanel.Width = 200;
            // 
            // 
            // 
            viewer1.Sidebar.ThumbnailsPanel.ContextMenu = null;
            viewer1.Sidebar.ThumbnailsPanel.Text = "サムネイル";
            viewer1.Sidebar.ThumbnailsPanel.Width = 200;
            viewer1.Sidebar.ThumbnailsPanel.Zoom = 0.1D;
            // 
            // 
            // 
            viewer1.Sidebar.TocPanel.ContextMenu = null;
            viewer1.Sidebar.TocPanel.Expanded = true;
            viewer1.Sidebar.TocPanel.Text = "見出しマップラベル";
            viewer1.Sidebar.TocPanel.Width = 200;
            viewer1.Sidebar.Width = 200;
            viewer1.Size = new Size(824, 441);
            viewer1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 443);
            Controls.Add(viewer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private GrapeCity.ActiveReports.Viewer.Win.Viewer viewer1;
    }
}