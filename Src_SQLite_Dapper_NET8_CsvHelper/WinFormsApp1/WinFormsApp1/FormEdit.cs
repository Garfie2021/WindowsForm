using Maintenance.Model;
using Maintenance.Sql;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class FormEdit : Form
    {
        private M���� _M����;

        public FormEdit(M���� m����)
        {
            InitializeComponent();

            _M���� = m���� == null ? new M����() : m����;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = _M����.Id.ToString();
                txtStart.Text = _M����.Start;
                txtEnd.Text = _M����.End;
                txtName.Text = _M����.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn�o�^_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("�o�^���܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _M����.Start = txtStart.Text;
                _M����.End = txtEnd.Text;
                _M����.Name = txtName.Text;

                if (_M����.Id == null)
                {
                    Sql����.Insert(_M����);
                }
                else
                {
                    Sql����.Update(_M����);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn�L�����Z��_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
