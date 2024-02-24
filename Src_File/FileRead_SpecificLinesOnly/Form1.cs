using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace FileRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnクリア_Click(object sender, EventArgs e)
        {
            txt特定行に含まれる文字列.Text = string.Empty;
        }

        private void btnファイル排他アクセス開始_Click_1(object sender, EventArgs e)
        {
            txt結果.Text = string.Empty;

            ファイル排他アクセス開始(txtファイル.Text);
        }

        private void btn特定行読込み開始_フォルダ_Click(object sender, EventArgs e)
        {
            txt結果.Text = string.Empty;

            foreach (var file in Directory.GetFiles(txtフォルダ.Text, "*", SearchOption.AllDirectories))
            {
                ファイル排他アクセス開始(file);
            }
        }

        private void ファイル排他アクセス開始(string txtファイル)
        {
            //ファイルのサイズを取得
            var fi = new FileInfo(txtファイル);
            var filesize = fi.Length;
            var sb = new StringBuilder((int)filesize * 2);

            // 読み込んだ結果をすべて格納するための変数を宣言する
            var stBuffer = string.Empty;

            //ファイルを開く
            using (var cReader = new StreamReader(txtファイル, Encoding.UTF8))
            {
                // 読み込みできる文字がなくなるまで繰り返す
                while (cReader.Peek() >= 0)
                {
                    // ファイルを 1 行ずつ読み込む
                    stBuffer = cReader.ReadLine();

                    if (rdo前方一致.Checked)
                    {
                        if (stBuffer.IndexOf(txt特定行に含まれる文字列.Text, StringComparison.Ordinal) != 0) continue;
                    }
                    else if (rdo部分一致.Checked)
                    {
                        if (stBuffer.IndexOf(txt特定行に含まれる文字列.Text, StringComparison.Ordinal) < 0) continue;
                    }
                    else
                    {
                        if (stBuffer.IndexOf(txt特定行に含まれる文字列.Text, StringComparison.Ordinal) < 0) continue;
                    }

                    // 読み込んだものを追加で格納する
                    sb.Append(stBuffer + Environment.NewLine);
                }

                // cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
                cReader.Close();

                // 結果を表示する
                txt結果.Text += sb.ToString();
            }
        }

    }
}
