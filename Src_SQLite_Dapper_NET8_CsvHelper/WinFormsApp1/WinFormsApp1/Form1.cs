using CsvHelper.Configuration;
using CsvHelper;
using Maintenance.Model;
using Maintenance.Sql;
using System.Globalization;

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
            try
            {
                Get政権();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn追加_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FormEdit(null))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog(this);
                    Get政権();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCSVファイルをインポート_Click(object sender, EventArgs e)
        {
            try
            {
                var dataList = LoadCsv(@"..\..\..\..\..\CSV\政権.csv");

                Sql政権.InsertRange(dataList);
                Get政権();

                MessageBox.Show("完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn全データ削除_Click(object sender, EventArgs e)
        {
            try
            {
                Sql政権.DeleteAll();
                Get政権();

                MessageBox.Show("完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    var selected = (M政権)senderGrid.Rows[e.RowIndex].DataBoundItem;

                    if (senderGrid.Columns[e.ColumnIndex].Name == "Clm編集")
                    {
                        using (var form = new FormEdit(selected))
                        {
                            form.StartPosition = FormStartPosition.CenterParent;
                            form.ShowDialog(this);
                            Get政権();
                        }
                    }
                    else if (senderGrid.Columns[e.ColumnIndex].Name == "Clm削除")
                    {
                        if (MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Sql政権.Delete(selected);
                            Get政権();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Get政権()
        {
            dataGridView1.DataSource = Sql政権.SelectAll();
            dataGridView1.Columns["Id"].Width = 50;
            dataGridView1.Columns["Start"].Width = 100;
            dataGridView1.Columns["End"].Width = 100;
            dataGridView1.Columns["Name"].Width = 200;
        }

        public List<M政権> LoadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null
            }))
            {
                var records = csv.GetRecords<M政権>();
                return new List<M政権>(records);
            }
        }

    }
}
