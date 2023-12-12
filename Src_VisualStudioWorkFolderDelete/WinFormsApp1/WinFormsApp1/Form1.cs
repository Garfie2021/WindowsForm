using System.Configuration;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDirectoryPath.Text = ConfigurationManager.AppSettings["DirectoryPath"];
        }

        private void btnフォルダ選択_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtDirectoryPath.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryPath.Text = folderBrowserDialog.SelectedPath;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["DirectoryPath"].Value = txtDirectoryPath.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void btnフォルダをリストアップ_Click(object sender, EventArgs e)
        {
            string directoryPath = txtDirectoryPath.Text;
            if (Directory.Exists(directoryPath))
            {
                var directories = Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories)
                    .Where(dir => dir.EndsWith("\\bin") || dir.EndsWith("\\obj"))
                    .Select(dir => new DirectoryItem { IsChecked = false, FolderPath = dir }).ToList();

                dgbFolderList.DataSource = directories;

                // チェックボックス列の設定
                dgbFolderList.Columns["IsChecked"].HeaderText = "選択";
                dgbFolderList.Columns["IsChecked"].Width = 50;

                // フォルダパス列の設定
                dgbFolderList.Columns["FolderPath"].HeaderText = "フォルダパス";
                dgbFolderList.Columns["FolderPath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                MessageBox.Show("指定されたパスが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn削除_Click(object sender, EventArgs e)
        {
            if (dgbFolderList.Rows.Count < 1 || !dgbFolderList.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToBoolean(row.Cells["IsChecked"].Value)))
            {
                MessageBox.Show("削除対象のフォルダが選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("選択したフォルダを本当に削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var log = "";
            List<string> deletedFolders = new List<string>();

            foreach (DataGridViewRow row in dgbFolderList.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["IsChecked"].Value);
                if (isChecked)
                {
                    string folderPath = row.Cells["FolderPath"].Value?.ToString() ?? string.Empty;
                    if (string.IsNullOrEmpty(folderPath))
                        continue;

                    try
                    {
                        Directory.Delete(folderPath, true);
                        log += $"{DateTime.Now}: {folderPath} を削除しました。\r\n";
                        deletedFolders.Add(folderPath);
                    }
                    catch (Exception ex)
                    {
                        log += $"{DateTime.Now}: {folderPath} の削除でエラーが発生しました。【{ex.Message}】\r\n";
                    }
                }
            }
            log += $"{DateTime.Now}: 削除完了しました。\r\n";

            File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{DateTime.Now.ToString("yyyyMMdd")}.log"), log);

            MessageBox.Show("フォルダを削除しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn全選択_Click(object sender, EventArgs e)
        {
            if (dgbFolderList.DataSource is List<DirectoryItem> items)
            {
                foreach (DirectoryItem item in items)
                {
                    item.IsChecked = true;
                }
                dgbFolderList.Refresh();
            }
        }

        private void btn全選択解除_Click(object sender, EventArgs e)
        {
            if (dgbFolderList.DataSource is List<DirectoryItem> items)
            {
                foreach (DirectoryItem item in items)
                {
                    item.IsChecked = false;
                }
                dgbFolderList.Refresh();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DirectoryPath"].Value = txtDirectoryPath.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}