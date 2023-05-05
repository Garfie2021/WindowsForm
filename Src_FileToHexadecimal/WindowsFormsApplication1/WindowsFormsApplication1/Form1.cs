using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ファイルを開くダイアログの生成
            var of = new OpenFileDialog();
            //ダイアログの表示
            var d = of.ShowDialog();

            //OKボタンが押されたらデータを読み込む処理へ
            if (d != DialogResult.OK) return;

            //ファイルパスの取得

            textBox1.Text = reed(of.FileName);

            MessageBox.Show("完了");
        }

        private static string reed(string filepass)
        {
            //ファイルをメモリへ読み込む
            using (var fs = new FileStream(filepass, 
                FileMode.Open, FileAccess.Read, FileShare.None))

            //バイナリ形式でプログラム内に読み込む
            using (var br = new BinaryReader(fs))
            {
                //ファイルサイズを求める
                var fi = new FileInfo(filepass);
                var filesize = (int)fi.Length;

                //配列の長さをファイルサイズにして定義
                //データを格納する変数
                var data = new byte[filesize];
                var sb = new StringBuilder(filesize * 2);

                //１バイトずつ取得しながら１６進数で表示
                for (var i = 1; i < filesize; i++)
                {
                    data[i] = br.ReadByte();
                    sb.AppendFormat("{0,2:x2} ", data[i]);
                }

                return sb.ToString();
            }
        }
    }
}
