using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain.Common.Data.Oracle;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_CONNECTION_TYPE connectionType = DB_CONNECTION_TYPE.OLEDB;

            if (cmbServerName.Text == DB_CONNECTION_TYPE.ODAC.ToString())
            {
                connectionType = DB_CONNECTION_TYPE.ODAC;
            }
            else if (cmbServerName.Text == DB_CONNECTION_TYPE.OLEDB.ToString())
            {
                connectionType = DB_CONNECTION_TYPE.OLEDB;
            }
            else if (cmbServerName.Text == DB_CONNECTION_TYPE.ODBC.ToString())
            {
                connectionType = DB_CONNECTION_TYPE.ODBC;
            }

            OracleAuditorParam param = new OracleAuditorParam();
            param.ServerName = ServerName.Text;
            param.InstanceName = InstanceName.Text;
            param.RacServiceName = RacServiceName.Text;
            param.IsEnableConnectionStr = false;
            param.ConnectionStr = "";
            param.OraclePortNo = OraclePortNo.Text;
            param.OracleUser = OracleUser.Text;
            param.OraclePW = OraclePW.Text;
            param.DBAPrivilege = cmbDBAPrivilege.Text;

            DbSupprt mDbs = new DbSupprt(param, connectionType);

            try
            {
                mDbs.connect();

                MessageBox.Show("接続OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("接続NG\r\n\r\n [" + ex.Message + "]");
            }
            finally
            {
                mDbs.disconnect();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbServerName.Text = "ODAC";
            cmbDBAPrivilege.Text = "SYSOPER";
        }
    }
}
