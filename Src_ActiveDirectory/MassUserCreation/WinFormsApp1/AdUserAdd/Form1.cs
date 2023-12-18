using System;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;

namespace AdUserAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region privateメソッド
        private void txtユーザ名Prefix_TextChanged()
        {
            txtユーザ名サンプル.Text = txtユーザ名Prefix.Text + "_{n}";
        }

        private void txtグループ名Prefix_TextChanged()
        {
            txtグループ名サンプル.Text = txtグループ名Prefix.Text + "_{n}";
        }

        private void txtグループに所属するユーザ名Prefix_TextChanged()
        {
            txtグループにユーザを追加_ユーザ名サンプル.Text = txtグループにユーザを追加_ユーザ名Prefix.Text + "_{n}";
        }
        private void txtグループにユーザを追加_グループ名Prefix_TextChanged()
        {
            txtグループにユーザを追加_グループ名サンプル.Text = txtグループにユーザを追加_グループ名Prefix.Text + "_{n}";
        }

        private void ユーザ追加(string ユーザ名Prefix, int i開始, int i終了)
        {
            try
            {
                DirectoryEntry myLdapConnection = new DirectoryEntry(txt接続文字列.Text, txtID.Text, txtPW.Text);

                myLdapConnection.Path = "LDAP://" + txtドメイン.Text;

                DirectoryEntry ou = myLdapConnection.Children.Find("OU=" + txtOU.Text);

                while (i開始 <= i終了)
                {
                    DirectoryEntry user = ou.Children.Add("CN=" + ユーザ名Prefix + "_" + i開始.ToString(), "user");

                    user.Properties["samAccountName"].Value = ユーザ名Prefix + "_" + i開始.ToString();

                    user.CommitChanges();

                    i開始++;
                }

                MessageBox.Show("ユーザ追加完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Exception]\r\n" + ex.ToString());
            }
        }

        private void グループ追加(string OU, string グループ名Prefix, int i開始, int i終了)
        {
            DirectoryEntry myLdapConnection = new DirectoryEntry(txt接続文字列.Text, txtID.Text, txtPW.Text);

            myLdapConnection.Path = "LDAP://" + txtドメイン.Text;

            DirectoryEntry ou = myLdapConnection.Children.Find("OU=" + OU);

            while (i開始 <= i終了)
            {
                DirectoryEntry user = ou.Children.Add("CN=" + グループ名Prefix + "_" + i開始.ToString(), "group");

                user.Properties["samAccountName"].Value = グループ名Prefix + "_" + i開始.ToString();

                user.CommitChanges();

                i開始++;
            }
        }

        private void グループにユーザを登録(string OU, string DC,
            string グループ名Prefix, int iグループ開始, int iグループ終了,
            string ユーザ名Prefix, int iユーザ開始, int iユーザ終了)
        {
            DirectoryEntry myLdapConnection = new DirectoryEntry(txt接続文字列.Text, txtID.Text, txtPW.Text);

            myLdapConnection.Path = "LDAP://" + txtドメイン.Text;

            Log.ExecLogWrite("myLdapConnection.Path : " + myLdapConnection.Path);
            Log.ExecLogWrite("OU : " + OU);

            DirectoryEntry ou = myLdapConnection.Children.Find("OU=" + OU);

            int iグループCnt = iグループ開始;
            while (iグループCnt <= iグループ終了)
            {
                //string strグループ名 = "CN=" + グループ名Prefix + "_" + iグループ開始.ToString();
                string strグループ名 = グループ名Prefix + "_" + iグループCnt.ToString();
                Log.ExecLogWrite("strグループ名 : " + strグループ名);

                var directorySearcher = new DirectorySearcher(myLdapConnection);
                directorySearcher.Filter = String.Format("(&(objectClass=group)(Name={0}))", strグループ名);

                var result = directorySearcher.FindOne();
                if (result == null)
                {
                    MessageBox.Show("グループが見つからない。[" + strグループ名 + "]");
                    return;
                }

                var group = result.GetDirectoryEntry();

                int iユーザCnt = iユーザ開始;
                while (iユーザCnt <= iユーザ終了)
                {
                    try
                    {
                        string strユーザ名 = ユーザ名Prefix + "_" + iユーザCnt.ToString();
                        string strLDAPユーザ名 = "CN=" + strユーザ名 + ",OU=" + OU + "," + DC;
                        Log.ExecLogWrite("strLDAPユーザ名 : " + strLDAPユーザ名);

                        group.Properties["member"].Add(strLDAPユーザ名);    //"CN=TestUserRA_1,OU=aaa,DC=domain2008r2,DC=local"
                        group.CommitChanges();
                    }
                    catch (Exception ex)
                    {
                        Log.ExecLogWrite(ex.Message);
                    }

                    iユーザCnt++;
                }

                iグループCnt++;
            }
        }
        #endregion

        #region イベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Log.LogFolderPath) == false)
            {
                Directory.CreateDirectory(Log.LogFolderPath);
            }

            txtユーザ名Prefix_TextChanged();
            txtグループ名Prefix_TextChanged();
            txtグループに所属するユーザ名Prefix_TextChanged();
            txtグループにユーザを追加_グループ名Prefix_TextChanged();
        }

        private void btnDC接続テスト_Click(object sender, EventArgs e)
        {
            try
            {
                //DirectoryEntry _AdRootDSE = new DirectoryEntry("LDAP://aa00sd11.〇〇.co.jp/dc=〇〇,dc=co,dc=jp", "〇〇.co.jp\\（ユーザアカウント名）", "password");
                //DirectoryEntry _AdRootDSE = new DirectoryEntry("LDAP://2008R2AD.domain2008r2.local/DC=domain2008r2,DC=local", "domain2008r2.local\\administrator", "password");
                DirectoryEntry _AdRootDSE = new DirectoryEntry(txt接続文字列.Text, txtID.Text, txtPW.Text);
                string strPath = (string)_AdRootDSE.Properties["defaultNamingContext"].Value;
                DirectoryEntry _AdRoot = new DirectoryEntry("LDAP://" + strPath);

                MessageBox.Show("接続OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region ユーザ追加 tab

        private void txtユーザ名Prefix_TextChanged(object sender, EventArgs e)
        {
            txtユーザ名Prefix_TextChanged();
        }

        private void btnユーザ追加_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryEntry myLdapConnection = new DirectoryEntry(txt接続文字列.Text, txtID.Text, txtPW.Text);

                myLdapConnection.Path = "LDAP://" + txtドメイン.Text;

                DirectoryEntry ou = myLdapConnection.Children.Find("OU=" + txtOU.Text);

                DirectoryEntry user = ou.Children.Add("CN=" + txtTestユーザ名.Text, "user");

                user.Properties["samAccountName"].Value = txtTestユーザ名.Text;

                user.CommitChanges();

                MessageBox.Show("ユーザ追加完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Exception]\r\n" + ex.ToString());
            }
        }

        private void btn大量ユーザ追加_Click(object sender, EventArgs e)
        {
            ユーザ追加(txtユーザ名Prefix.Text, int.Parse(txtユーザ数_開始.Text), int.Parse(txtユーザ数_終了.Text));
        }
        #endregion

        #region グループ追加 tab
        private void txtグループ名Prefix_TextChanged(object sender, EventArgs e)
        {
            txtグループ名Prefix_TextChanged();
        }

        private void btn大量グループ追加_Click(object sender, EventArgs e)
        {
            try
            {
                グループ追加(txtOU.Text, 
                    txtグループ名Prefix.Text, int.Parse(txtグループ名Sufix_開始.Text), int.Parse(txtグループ名Sufix_終了.Text));

                MessageBox.Show("グループ追加完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Exception]\r\n" + ex.ToString());
            }
        }
        #endregion

        #region グループ追加 tab
        private void txtグループに所属するユーザ名Prefix_TextChanged(object sender, EventArgs e)
        {
            txtグループに所属するユーザ名Prefix_TextChanged();
        }

        private void txtグループにユーザを追加_グループ名Prefix_TextChanged(object sender, EventArgs e)
        {
            txtグループにユーザを追加_グループ名Prefix_TextChanged();
        }

        private void btn大量グループにメンバ追加_Click(object sender, EventArgs e)
        {
            try
            {
                グループにユーザを登録(txtOU.Text, txtDC.Text,
                    txtグループにユーザを追加_グループ名Prefix.Text,
                    int.Parse(txtグループにユーザを追加_グループ名Sufix_開始.Text), int.Parse(txtグループにユーザを追加_グループ名Sufix_終了.Text),
                    txtグループにユーザを追加_ユーザ名Prefix.Text,
                    int.Parse(txtグループにユーザを追加_ユーザ名Sufix_開始.Text), int.Parse(txtグループにユーザを追加_ユーザ名Sufix_終了.Text));

                MessageBox.Show("グループメンバ追加完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Exception]\r\n" + ex.ToString());
            }
        }
        #endregion

        #endregion
    }
}



