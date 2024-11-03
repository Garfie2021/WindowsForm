using Maintenance.Model;
using Maintenance.Sql;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class FormEdit : Form
    {
        private Mê≠å† _Mê≠å†;

        public FormEdit(Mê≠å† mê≠å†)
        {
            InitializeComponent();

            _Mê≠å† = mê≠å† == null ? new Mê≠å†() : mê≠å†;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = _Mê≠å†.Id.ToString();
                txtStart.Text = _Mê≠å†.Start;
                txtEnd.Text = _Mê≠å†.End;
                txtName.Text = _Mê≠å†.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnìoò^_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ìoò^ÇµÇ‹Ç∑Ç©ÅH", "ämîF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _Mê≠å†.Start = txtStart.Text;
                _Mê≠å†.End = txtEnd.Text;
                _Mê≠å†.Name = txtName.Text;

                if (_Mê≠å†.Id == null)
                {
                    Sqlê≠å†.Insert(_Mê≠å†);
                }
                else
                {
                    Sqlê≠å†.Update(_Mê≠å†);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnÉLÉÉÉìÉZÉã_Click(object sender, EventArgs e)
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
