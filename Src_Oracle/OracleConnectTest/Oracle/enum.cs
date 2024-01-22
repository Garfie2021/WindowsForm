namespace Domain.Common.Data.Oracle
{
    // DBの接続方法
    public enum DB_CONNECTION_TYPE : uint
    {
        NONE = 0,
        ODBC = 1,   // ODBC接続
        ODAC = 2,   // ODAC接続（Oracle.DataAccess）
        OLEDB = 3   // OLEDB接続（OLE DB .NET Data Provider ）
    }

    /// <summary>
    /// 動作タイプ
    /// </summary>
    public enum Privilege : uint
    {
        SYSOPER = 0,
        SYSDBA = 1
    }

}
