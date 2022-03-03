using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static Dictionary<string, string> mDict = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //実証実験1();
            //実証実験2();
            //実証実験3();
            実証実験4();
        }

        // メソッド内の変数でループするstaticメソッドを、シングルスレッドで実行する。
        private void 実証実験1()
        {
            var Variable実験 = new CVariable実験1();
            Variable実験.VariableTest1("A");
            Variable実験.VariableTest1("B");
            Variable実験.VariableTest1("C");
        }

        // メソッド内の変数でループするstaticメソッドを、マルチスレッドで実行する。
        private void 実証実験2()
        {
            var Variable実験 = new CVariable実験1();
            var i1 = new Thread(new ParameterizedThreadStart(Variable実験.VariableTest1));
            var t2 = new Thread(new ParameterizedThreadStart(Variable実験.VariableTest1));
            var t3 = new Thread(new ParameterizedThreadStart(Variable実験.VariableTest1));

            i1.Start("A");
            t2.Start("B");
            t3.Start("C");
        }

        // クラスのstaticメンバ変数でループするstaticメソッドを、シングルスレッドで実行する。
        private void 実証実験3()
        {
            var Variable実験 = new CVariable実験1();
            Variable実験.VariableTest2("A");
            Variable実験.VariableTest2("B");
            Variable実験.VariableTest2("C");
        }

        // クラスのメンバ変数でループするメソッドを、マルチスレッドで実行する。
        private void 実証実験4()
        {
            var Variable実験 = new CVariable実験1();
            var i1 = new Thread(new ParameterizedThreadStart(Variable実験.VariableTest2));
            var t2 = new Thread(new ParameterizedThreadStart(Variable実験.VariableTest2));
            var t3 = new Thread(new ParameterizedThreadStart(Variable実験.VariableTest2));

            i1.Start("A");
            t2.Start("B");
            t3.Start("C");
        }

    }
}
