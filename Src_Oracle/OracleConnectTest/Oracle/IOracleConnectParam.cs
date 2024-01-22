namespace Domain.Common.Data.Oracle
{
    public interface IOracleConnectParam
    {
        string ServerName { get; set; }       // サーバー名
        string InstanceName { get; set; }     // Oracleインスタンス名
        string RacServiceName { get; set; }   // Oracleサービス名（RAC使用時）
        bool IsEnableConnectionStr { get; set; }
        string ConnectionStr { get; set; }    // 接続文字列直打ちでOracle接続する場合に使用する接続文字列
        string OraclePortNo { get; set; }           // ポート番号
        string OracleUser { get; set; }             // ユーザ名
        string OraclePW { get; set; }               // パスワード
        string DBAPrivilege { get; set; }
    }
}
