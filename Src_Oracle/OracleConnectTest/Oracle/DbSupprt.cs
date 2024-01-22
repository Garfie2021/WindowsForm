using System;
using System.Data;

namespace Domain.Common.Data.Oracle
{
    /// <summary>
    /// DB接続補助クラス
    /// コンフィグファイルの接続タイプの種類よって接続方法の切り替えを行い、接続、切断、SQLの実行を行う
    /// </summary>
    public class DbSupprt
    {
        #region メンバ変数

        public IConnect dbIf = null;
        private IOracleConnectParam mParam = null;

        #endregion


        #region publicメソッド

        /// <summary>
        /// 接続タイプの種類よって接続方法の切り替えを行う
        /// </summary>
        /// <param name="dbi">DB設定情報</param>
        public DbSupprt(IOracleConnectParam param, DB_CONNECTION_TYPE connectionType)
        {
            mParam = param;
            _DbSupprt(connectionType);
        }

        /// <summary>
        /// DBに接続するタイプを変える
        /// </summary>
        /// <param name="dBConnectType">
        /// 入力値無し（デフォルト）：Odbc
        /// Const.STR_ODAC			：ODAC
        /// Const.STR_OLEDB			：OLEDB
        /// その他					：Odbc
        /// </param>
        public void _DbSupprt(DB_CONNECTION_TYPE dBConnectType)
        {
            if (dBConnectType == DB_CONNECTION_TYPE.ODAC)
            {
                dbIf = new OdacConnect();
            }
            else if (dBConnectType == DB_CONNECTION_TYPE.OLEDB)
            {
                dbIf = new OledbConnect();
            }
            else if (dBConnectType == DB_CONNECTION_TYPE.ODBC)
            {
                dbIf = new OdbcConnect();
            }
            else
            {
                // デフォルト
                dbIf = new OledbConnect();
            }
        }

        // DBとの接続
        public bool connect()
        {
            string connStr = "";

            // 入力情報により接続文字列の作成に使用される情報を変更する

            if (mParam.IsEnableConnectionStr)
            {
                // 接続文字列直打ちorネットサービス名で接続する場合

                connStr = mParam.ConnectionStr;
            }
            else
            {
                // サービス名で接続する場合

                string server = mParam.ServerName;
                string port = mParam.OraclePortNo;

                // サービス名がない場合はインスタンス名を接続に使用する
                string instace = String.IsNullOrEmpty(mParam.RacServiceName) ? mParam.InstanceName : mParam.RacServiceName;

                // 入力がない場合のポート番号はデフォルトの1521
                if (String.IsNullOrEmpty(port))
                {
                    port = "1521";
                }

                connStr = server + ":" + port + "/" + instace;
            }

            dbIf.connect(connStr, mParam.InstanceName, mParam.OracleUser, mParam.DBAPrivilege, mParam.OraclePW);

            return true;
        }

        // 成功か失敗かを知りたい場合
        public bool excuteQuery(string queryString)
        {
            DataTable tb = null;

            return _excuteQuery(queryString, ref tb);
        }

        // 実行結果の詳細を取得したい場合
        public bool excuteQuery(string queryString, ref DataTable tb)
        {
            return _excuteQuery(queryString, ref tb);
        }

        public void disconnect()
        {
            dbIf.disconnect();
        }

        public void commit()
        {
            dbIf.commitTransaction();
        }

        #endregion


        #region privateメソッド

        private bool _excuteQuery(string queryString, ref DataTable tb)
        {
            bool ret = false;
            tb = dbIf.executeSql(queryString);
            ret = true;

            return ret;
        }

        #endregion
    }
}
