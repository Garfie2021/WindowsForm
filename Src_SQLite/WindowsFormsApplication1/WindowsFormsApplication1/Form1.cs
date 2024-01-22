using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public const string SQLITE_CONNECTION_STRING = "Data Source=..\\..\\..\\TestData\\test.db;New=False;UTF8Encoding=True;Version=3;Password=pass;Enlist=False;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(SQLITE_CONNECTION_STRING))
            {
                conn.Open();

                using (SQLiteCommand command = conn.CreateCommand())
                {
                    command.CommandText = "delete from table1;";
                    //command.CommandText = "VACUUM tempGroup;";
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }


        }
    }
}
