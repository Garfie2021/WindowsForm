using System;
using System.IO;
using System.Windows.Forms;


namespace AdUserAdd
{
    public static class Log
    {
        #region private staticメソッド

        public static string LogFolderPath = Environment.CurrentDirectory + @"\log";

        private static string TraceLogFilePath = LogFolderPath + @"\trace.log";
        private static string ExecLogFilePath = LogFolderPath + @"\exec.log";


        public static void ExecLogWrite(string log)
        {
            File.AppendAllText(ExecLogFilePath, DateTime.Now.ToString() + "\t" + log + "\r\n");
        }

        public static void TraceLogWrite(Exception ex)
        {
            File.AppendAllText(TraceLogFilePath, DateTime.Now.ToString() + "\t" + ex.Message + "\r\n" + ex.StackTrace + "\r\n");

            MessageBox.Show("実行時にエラーが発生しました。\r\n\r\n" + ex.Message);
        }

        #endregion
    }
}
