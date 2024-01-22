using System;
using System.Data;
using System.Data.Odbc;

namespace Domain.Common.Data.Oracle
{
    /// <summary>
    /// ODBCを使用してOracleに接続するためのクラスです。
    /// 予めLOCALシステムに接続先のOracleに対して接続可能な
    /// DNS（データソースネーム）が設定されている必要があります
    /// Odbcによる接続
    /// </summary>
    public class OdbcConnect : IConnect
    {
        #region メンバ変数

        private OdbcConnection _con = null;
        private OdbcTransaction _trn = null;

        #endregion


        #region publicメソッド

        // 接続
        public override void _connect(string dsn, string dbn, string uid, string pas, string priv, int tot)
        {
            if (_con == null)
            {
                _con = new OdbcConnection();
            }

            string cst = "";
            cst = cst + ";DSN=" + dsn;
            cst = cst + ";Database=" + dbn;
            cst = cst + ";UID=" + uid;
            cst = cst + ";PWD=" + pas;

            if (tot > -1)
            {
                cst = cst + ";Connect Timeout=" + tot.ToString();
            }

            OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder();
            builder.Add("DSN", dsn);
            builder.Add("Database", dbn);
            builder.Add("Uid", uid);
            builder.Add("Pwd", pas);

            _con.ConnectionString = cst;

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

            OdbcCommand sqlCommand = new OdbcCommand(sql, _con, _trn);

            if (tot > -1)
            {
                sqlCommand.CommandTimeout = tot;
            }

            OdbcDataAdapter adapter = new OdbcDataAdapter(sqlCommand);

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

        #endregion
    }
}
