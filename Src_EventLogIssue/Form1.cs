using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EventLogIssue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ソースが存在していない時は、作成する
            if (!EventLog.SourceExists(txtソース.Text))
            {
                //ログ名を空白にすると、"Application"となる
                EventLog.CreateEventSource(txtソース.Text, "");
            }

            //テスト用にイベントログエントリに付加するデータを適当に作る
            byte[] myData = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //イベントログにエントリを書き込む
            //ここではエントリの種類をエラー、イベントIDを1、分類を1000とする
            EventLog.WriteEntry(txtソース.Text, txt説明.Text,
                EventLogEntryType.Information, int.Parse(txtイベントID.Text), 1000, myData);

        }
    }
}
