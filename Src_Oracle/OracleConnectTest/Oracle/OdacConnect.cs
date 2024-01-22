using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Domain.Common.Data.Oracle
{
    /// <summary>
    /// Odac(Oracle.DataAccess.dll)を使用してOracleに接続するためのクラスです。
    /// Oracle.DataAccess.dllのバージョンが適切でないと接続できません。
    /// OracleDataAccessCliantによる接続
    /// </summary>
    public class OdacConnect : IConnect
    {
        #region privateメソッド

        private OracleConnection _con = null;
        private OracleTransaction _trn = null;

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

                    // 接続文字列のコンバート
                    dsn = convertConnectString(dsn);

                    //OracleConnectionStringBuilder connStrBuilder = new OracleConnectionStringBuilder();
                    //connStrBuilder.Add("User Id", uid);
                    //connStrBuilder.Add("Password", pas);
                    //connStrBuilder.Add("Data Source", dsn);

                    string cst = "";
                    cst = cst + "Data Source=" + dsn;
                    cst = cst + ";User Id=" + uid;
                    cst = cst + ";Password=" + pas;

                    if (uid.ToUpper().Equals("SYS"))
                    {
                        cst = cst + ";DBA Privilege=SYSDBA";
                    }

                    //_con = new OracleConnection(connStrBuilder.ConnectionString);
                    _con = new OracleConnection(cst);
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
            OracleCommand sqlCommand = new OracleCommand(sql, _con);

            if (_trn == null)
            {
                beginTransaction();
            }

            if (tot > -1)
            {
                sqlCommand.CommandTimeout = tot;
            }

            OracleDataAdapter adapter = new OracleDataAdapter(sqlCommand);

            adapter.Fill(dt);
            adapter.Dispose();
            sqlCommand.Dispose();

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

        // トランザクション開始
        public override void beginTransaction()
        {
            try
            {
                _trn = _con.BeginTransaction();
            }
            catch (Exception ex)
            {
                throw;
            }
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
                // dnsとしてtnsNameが入力されている
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
