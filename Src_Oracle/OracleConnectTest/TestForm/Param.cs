using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common.Data.Oracle;

namespace TestForm
{
    public class OracleAuditorParam : IOracleConnectParam
    {
        #region メンバ変数

        /// <summary>
        /// イベントログOS設定をデフォルトで設定するか？
        /// </summary>
        public bool UpdatesEventLogConfiguration { get; set; }

        #region OraGet実行前に設定する

        /// <summary>
        /// 監査設定内容
        /// true：監査設定を行う false：監査設定を削除する
        /// </summary>
        public bool isCreateAuditSetting = true;

        /// <summary>
        /// 監査設定の有効無効
        /// </summary>
        public bool IsEnable = false;

        /// <summary>
        /// サーバー名
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Oracle IP
        /// </summary>
        //public string OracleIP { get; set; }

        /// <summary>
        /// Oracleポート番号
        /// </summary>
        public string OraclePortNo { get; set; }

        /// <summary>
        /// Oracleインスタンス名
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// Oracleサービス名（RAC使用時）
        /// </summary>
        public string RacServiceName { get; set; }

        /// <summary>
        /// 「TNSサービス名または接続文字列を指定して接続する」チェックボックスの状態
        /// true：チェック有り　true：チェック無し
        /// </summary>
        public bool IsEnableConnectionStr { get; set; }

        /// <summary>
        /// 接続文字列直打ちでOracle接続する場合に使用する接続文字列
        /// </summary>
        public string ConnectionStr { get; set; }

        /// <summary>
        /// DBへの接続方法
        /// ODBC or ODAC or OLEDB
        /// </summary>
        //public DB_CONNECTION_TYPE DBConnectType { get; set; }

        /// <summary>
        /// Oracleユーザ名
        /// </summary>
        public string OracleUser { get; set; }

        /// <summary>
        /// Oracleユーザパスワード
        /// </summary>
        public string OraclePW { get; set; }

        public string DBAPrivilege { get; set; }
        

        /// <summary>
        /// DBのバージョン
        /// </summary>
        public string DBVersion = null;

        /// <summary>
        /// Oracleへ接続時の権限
        /// </summary>
        //public string Privilege { get; set; }

        /// <summary>
        /// トレースファイルの出力先パス
        /// </summary>
        public string TraceOutPath = null;

        /// <summary>
        /// オブジェクトに対するSELECTのログ（オブジェクト監査のSelect）を有効にするか
        /// 的にアクセスログ（SELECT）といわれるもの
        /// 的にSELECTログ（アクセスログ）といわれるもの
        /// </summary>
        public bool IsEnableAuditSelect = false;

        /// <summary>
        /// オブジェクトに対するSELECTのログ（オブジェクト監査のInsert）を有効にするか
        /// 的にアクセスログ（INSERT）といわれるもの
        /// </summary>
        public bool IsEnableAuditInsert = false;

        /// <summary>
        /// オブジェクトに対するSELECTのログ（オブジェクト監査のUpdate）を有効にするか
        /// 的にアクセスログ（UPDATE）といわれるもの
        /// </summary>
        public bool IsEnableAuditUpdate = false;

        /// <summary>
        /// オブジェクトに対するSELECTのログ（オブジェクト監査のDelete）を有効にするか
        /// 的にアクセスログ（DELETE）といわれるもの
        /// </summary>
        public bool IsEnableAuditDelete = false;

        /// <summary>
        /// オブジェクトに対するSELECTのログ（オブジェクト監査のLogon）を有効にするか
        /// </summary>
        public bool IsEnableAuditLogon = false;

        /// <summary>
        /// オブジェクトに対するSELECTのログ（オブジェクト監査のLogoff）を有効にするか
        /// </summary>
        public bool IsEnableAuditLogoff = false;

        /// <summary>
        /// 管理者操作ログ
        /// （true:収集する、false:収集しない）
        /// </summary>
        public bool IsEnableAdminLog = false;

        /// <summary>
        /// SYSDBA監査を有効にするかしないか
        /// </summary>
        public bool IsEnableSysdb = false;

        /// <summary>
        /// XML出力に「EXTENDED」を指定するかどうか。
        /// SQLトレースログの収集フラグ
        /// 的にトレースログ（RAWSQL）といわれるもの
        /// （true:収集する、false:収集しない）
        /// </summary>
        public bool IsEnableRawSql = false;

        /// <summary>
        /// アクセスログの収集フラグ。 的にアクセスログといわれるもの
        /// （true:収集する、false:収集しない）
        /// </summary>
        //public bool IsEnableAccessLog = false;

        #endregion


        #region 実質固定になっているパラメータ

        /// <summary>
        /// トリガによるアプリケーション名出力
        /// アプリケーション名を取得するかしないか
        /// （true:収集する、false:収集しない）
        /// </summary>
        public bool IsEnableAplicationLog = true;

        /// <summary>
        /// FTP/SFTP処理に失敗した際、リトライする最大数。デフォルト=5。
        /// </summary>
        public int mFtpRetryMax = 5;

        #endregion

        #endregion
    }
}
