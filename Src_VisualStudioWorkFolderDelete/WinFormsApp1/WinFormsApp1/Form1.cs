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

        private void btn�t�H���_�I��_Click(object sender, EventArgs e)
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

        private void btn�t�H���_�����X�g�A�b�v_Click(object sender, EventArgs e)
        {
            string directoryPath = txtDirectoryPath.Text;
            if (Directory.Exists(directoryPath))
            {
                var directories = Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories)
                    .Where(dir => dir.EndsWith("\\bin") || dir.EndsWith("\\obj"))
                    .Select(dir => new DirectoryItem { IsChecked = false, FolderPath = dir }).ToList();

                dgbFolderList.DataSource = directories;

                // �`�F�b�N�{�b�N�X��̐ݒ�
                dgbFolderList.Columns["IsChecked"].HeaderText = "�I��";
                dgbFolderList.Columns["IsChecked"].Width = 50;

                // �t�H���_�p�X��̐ݒ�
                dgbFolderList.Columns["FolderPath"].HeaderText = "�t�H���_�p�X";
                dgbFolderList.Columns["FolderPath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                MessageBox.Show("�w�肳�ꂽ�p�X�����݂��܂���B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn�폜_Click(object sender, EventArgs e)
        {
            if (dgbFolderList.Rows.Count < 1 || !dgbFolderList.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToBoolean(row.Cells["IsChecked"].Value)))
            {
                MessageBox.Show("�폜�Ώۂ̃t�H���_���I������Ă��܂���B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("�I�������t�H���_��{���ɍ폜���܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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
                        log += $"{DateTime.Now}: {folderPath} ���폜���܂����B\r\n";
                        deletedFolders.Add(folderPath);
                    }
                    catch (Exception ex)
                    {
                        log += $"{DateTime.Now}: {folderPath} �̍폜�ŃG���[���������܂����B�y{ex.Message}�z\r\n";
                    }
                }
            }
            log += $"{DateTime.Now}: �폜�������܂����B\r\n";

            File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{DateTime.Now.ToString("yyyyMMdd")}.log"), log);

            MessageBox.Show("�t�H���_���폜���܂����B", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn�S�I��_Click(object sender, EventArgs e)
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

        private void btn�S�I������_Click(object sender, EventArgs e)
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