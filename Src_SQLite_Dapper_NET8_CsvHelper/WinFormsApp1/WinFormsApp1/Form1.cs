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
                Get����();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn�ǉ�_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FormEdit(null))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog(this);
                    Get����();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCSV�t�@�C�����C���|�[�g_Click(object sender, EventArgs e)
        {
            try
            {
                var dataList = LoadCsv(@"..\..\..\..\..\CSV\����.csv");

                Sql����.InsertRange(dataList);
                Get����();

                MessageBox.Show("����");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn�S�f�[�^�폜_Click(object sender, EventArgs e)
        {
            try
            {
                Sql����.DeleteAll();
                Get����();

                MessageBox.Show("����");
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
                    var selected = (M����)senderGrid.Rows[e.RowIndex].DataBoundItem;

                    if (senderGrid.Columns[e.ColumnIndex].Name == "Clm�ҏW")
                    {
                        using (var form = new FormEdit(selected))
                        {
                            form.StartPosition = FormStartPosition.CenterParent;
                            form.ShowDialog(this);
                            Get����();
                        }
                    }
                    else if (senderGrid.Columns[e.ColumnIndex].Name == "Clm�폜")
                    {
                        if (MessageBox.Show("�폜���܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Sql����.Delete(selected);
                            Get����();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Get����()
        {
            dataGridView1.DataSource = Sql����.SelectAll();
            dataGridView1.Columns["Id"].Width = 50;
            dataGridView1.Columns["Start"].Width = 100;
            dataGridView1.Columns["End"].Width = 100;
            dataGridView1.Columns["Name"].Width = 200;
        }

        public List<M����> LoadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null
            }))
            {
                var records = csv.GetRecords<M����>();
                return new List<M����>(records);
            }
        }

    }
}
