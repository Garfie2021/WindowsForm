using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Domain.Common.Data.Oracle
{
    /// <summary>
    /// OLEDBを使用してOracleに接続するためのクラスです。
    /// OLE DB .NET Data Providerによる接続
    /// </summary>
    public class OledbConnect : IConnect
    {
        #region メンバ変数

        private OleDbConnection _con = null;
        private OleDbTransaction _trn = null;

        #endregion


        #region public staticメソッド

        /// <summary>
        /// sql文の文末の";"を削除する
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string chastSqlstring(string sql)
        {
            string ret = "";

            if (sql.LastIndexOf(";") == sql.Length - 1)
            {
                ret = sql.Substring(0, sql.Length - 1);
            }
            else
            {
                ret = sql;
            }

            return ret;
        }

        #endregion


        #region publicメソッド

        // 接続
        public override void _connect(string dsn, string dbn, string uid, string pas, string priv, int tot)
        {
            try
            {
                if (_con == null)
                {
                    //// 64bit機で動かないのでOraOLEDB.Oracleを使用する
                    //string cst = "Provider=OraOLEDB.Oracle";
                    //cst = cst + ";User Id=" + uid;
                    //cst = cst + ";Password=" + pas;
                    //cst = cst + ";Data Source=" + dsn;
                    //cst = cst + ";DBA Privilege=" + priv;
                    //cst = cst + ";Persist Security Info=False";
                    OleDbConnectionStringBuilder connStrBuilder = new OleDbConnectionStringBuilder();
                    connStrBuilder.Add("Provider", "OraOLEDB.Oracle");
                    connStrBuilder.Add("User Id", uid);
                    connStrBuilder.Add("Password", pas);
                    connStrBuilder.Add("Data Source", convertConnectString(dsn));
                    //connStrBuilder.Add("DBA Privilege", priv);
                    connStrBuilder.Add("Persist Security Info", "False");

                    //_con = new OleDbConnection(cst);
                    _con = new OleDbConnection(connStrBuilder.ConnectionString);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                _con.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // 実行
        public override DataTable _executeSql(string sql, int tot)
        {
            DataTable dt = new DataTable();

            // SQLクエリのコンバート
            sql = chastSqlstring(sql);
            using (OleDbCommand sqlCommand = new OleDbCommand(sql, _con))
            {
                if (tot > -1)
                {
                    sqlCommand.CommandTimeout = tot;
                }

                //sqlCommand.ExecuteNonQuery();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlCommand))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        // 切断
        public override void disconnect()
        {
            if (_con != null)
            {
                if (_con.State == ConnectionState.Open)
                {
                    try
                    {
                        _con.Close();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    finally
                    {
                        rollbackTransaction();
                        _con.Dispose();
                    }
                }
            }
        }

        //トランザクション開始
        public override void beginTransaction()
        {
        }

        // コミット
        public override void commitTransaction()
        {
            try
            {
                if (_trn != null)
                {
                    _trn.Commit();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _trn = null;
            }
        }

        // ロールバック
        public override void rollbackTransaction()
        {
            try
            {
                if (_trn != null)
                {
                    _trn.Rollback();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _trn = null;
            }
        }

        // ファイナライズ
        public override void finalize()
        {
            disconnect();
        }

        /// <summary>
        /// 文字列の最後に";"があるとエラーになるため入力された接続文字列を接続に必要な形に加工する
        /// </summary>
        /// <param name="dns">接続文字列（ip:port/instance OR tnsName）</param>
        /// <returns>加工された文字列（入力値が不正な場合はNull）</returns>
        public string convertConnectString(string dns)
        {
            string tnsnameconnect = "";
            string[] tns = null;
            string tnsname = "";

            if (getDsnParam(dns, ref tns, ref tnsname))
            {
                if (tns != null)
                {
                    // dnsとしてip:port/instanceが入力されている
                    tnsnameconnect = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = " + tns[0] +
                                     ")(PORT = " + tns[1] +
                                     ")))(CONNECT_DATA = (SERVICE_NAME = " + tns[2] + ")))";
                }
                else if (!String.IsNullOrEmpty(tnsname))
                {
                    // dnsとしてtnsNameが入力されている
                    tnsnameconnect = tnsname;
                }
                else
                {
                    tnsnameconnect = null;
                }
            }

            return tnsnameconnect;
        }

        #endregion


        #region privateメソッド

        /// <summary>
        /// 入力された接続文字列から接続に必要な値を切り出す
        /// </summary>
        /// <param name="dsn">接続文字列</param>
        /// <param name="tns">tnsパラメータ</param>
        /// <param name="tnsname">localのtnsnames.oraに記載されているtnsname</param>
        /// <returns></returns>
        private bool getDsnParam(string dsn, ref string[] tns, ref string tnsname)
        {
            bool ret = false;

            if (dsn.Contains(":") && dsn.Contains("/"))
            {
                // dnsとしてip:port/instanceが入力されている
                string ip = "";
                string port = "";
                string instance = "";
                ip = dsn.Substring(0, dsn.IndexOf(":"));
                port = dsn.Substring(dsn.IndexOf(":") + 1, dsn.IndexOf("/") - 1 - dsn.IndexOf(":"));
                instance = dsn.Substring(dsn.IndexOf("/") + 1);
                tns = new string[3];
                tns[0] = ip;
                tns[1] = port;
                tns[2] = instance;

                ret = true;
            }
            else if (!dsn.Contains(":") && !dsn.Contains("/"))
            {
                // dnsとしてSID/tnsNameなどが入力されている
                tnsname = dsn;

                ret = true;
            }
            else
            {
                // dnsとして不正な文字列
                ret = false;
            }

            return ret;
        }

        #endregion

    }
}
