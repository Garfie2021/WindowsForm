using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThirdPartyProducts;

namespace StubController
{
    public partial class Form1 : Form
    {
        public List<StubSetting> _StubSettingList = new List<StubSetting>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //各クラスとそのメンバを、設定項目としてリストアップ
            SetStubSettingList(typeof(ThirdPartyProductOps), ref _StubSettingList);

            //ReturnCodeの一覧をコンボボックスにセット
            this.returnCodeDataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(ReturnCode));
            this.returnCodeDataGridViewTextBoxColumn.DataPropertyName = "ReturnCode";
            this.returnCodeDataGridViewTextBoxColumn.Name = "ReturnCode";

            //I/F一覧をDataGridViewにセット
            this.dataGridView1.DataSource = _StubSettingList;

            //DataGridViewの各列の幅を調整
            this.classNameDataGridViewTextBoxColumn.Width = 300;
            this.methodNameDataGridViewTextBoxColumn.Width = 150;
            this.returnCodeDataGridViewTextBoxColumn.Width = 150;
        }

        /// <summary>
        /// 反映ボタンクリック
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 編集を確定
            this.dataGridView1.EndEdit();

            // 確定した値をファイルに反映
            StubSettingFile.Write(_StubSettingList);
        }

        /// <summary>
        ///スタブの各クラスとそのメンバを、設定項目としてリストアップ
        /// </summary>
        private static void SetStubSettingList(Type tppClass, ref List<StubSetting> stubSettingList)
        {
            foreach (var member in tppClass.GetMembers())
            {
                if (member.MemberType == System.Reflection.MemberTypes.Property)
                {
                    stubSettingList.Add(new StubSetting() { ClassName = tppClass.FullName, MethodName = member.Name, ReturnCode = ReturnCode.Success });
                }
                else if (member.MemberType == System.Reflection.MemberTypes.Method)
                {
                    stubSettingList.Add(new StubSetting() { ClassName = tppClass.FullName, MethodName = member.Name, ReturnCode = ReturnCode.Success });
                }
            }

            // メソッド名を昇順でソートしておく
            stubSettingList.Sort((a, b) => string.Compare(b.MethodName, a.MethodName) * -1);
        }

    }
}
