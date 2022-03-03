using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    // staticメソッド群を、マルチスレッドで実行するためのメソッド群
    public class CVariable実験1
    {
        // メソッド内の変数を使ってループするメソッド
        public void VariableTest1(object id)
        {
            CVariable実験2.VariableTest1(id);
        }

        // クラスのメンバ変数を使ってループするメソッド
        public void VariableTest2(object id)
        {
            CVariable実験2.VariableTest2(id);
        }
    }

    // staticメソッド群
    public static class CVariable実験2
    {
        private static long mCnt = 0;

        // メソッド内の変数を使ってループするメソッド
        public static void VariableTest1(object id)
        {
            string FileName = "result_" + id + ".txt";

            if (File.Exists(FileName)) File.Delete(FileName);

            long iCnt = 0;
            string tmp = null;

            while (iCnt < 1000)
            {
                tmp = id + " " + iCnt.ToString() + "\r\n";

                System.Diagnostics.Debug.WriteLine(tmp);
                File.AppendAllText(FileName, tmp);

                iCnt++;
            }
        }

        // クラスのメンバ変数を使ってループするメソッド
        public static void VariableTest2(object id)
        {
            string FileName = "result_" + id + ".txt";

            if (File.Exists(FileName)) File.Delete(FileName);

            string tmp = null;
            mCnt = 0;

            while (mCnt < 1000)
            {
                tmp = id + " " + mCnt.ToString() + "\r\n";

                System.Diagnostics.Debug.WriteLine(tmp);
                File.AppendAllText(FileName, tmp);

                mCnt++;
            }
        }
    }
}
