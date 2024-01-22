using System.Data;

namespace Domain.Common.Data.Oracle
{
    /// <summary>
    /// 接続クラスのインターフェースです。
    /// </summary>
    public abstract class IConnect
    {
        // 接続
        public void connect(string dsn, string dbn, string uid, string priv, string pas)
        {
            _connect(dsn, dbn, uid, pas, priv, -1);
        }

        public void connect(string dsn, string dbn, string uid, string pas, string priv, int tot)
        {
            _connect(dsn, dbn, uid, pas, priv, tot);
        }

        // 実行
        public DataTable executeSql(string sql)
        {
            return _executeSql(sql, -1);
        }

        public DataTable executeSql(string sql, int tot)
        {
            return _executeSql(sql, tot);
        }

        // 継承するクラスで実装を行う関数

        // 接続
        public abstract void _connect(string dsn, string dbn, string uid, string pas, string priv, int tot);

        // 実行
        public abstract DataTable _executeSql(string sql, int tot);

        // 切断
        public abstract void disconnect();

        // トランザクション開始
        public abstract void beginTransaction();

        // コミット
        public abstract void commitTransaction();

        // ロールバック
        public abstract void rollbackTransaction();

        // ファイナライズ
        public abstract void finalize();
    }
}
