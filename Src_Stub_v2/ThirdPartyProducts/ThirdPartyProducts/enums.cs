using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyProducts
{
    public enum Status : uint
    {
        /// <summary>
        /// 未起動
        /// </summary>
        NotStarted = 0x00000000,

        /// <summary>
        /// 起動済み
        /// </summary>
        Started = 0x00000001,

        /// <summary>
        /// 処理１は終了している
        /// </summary>
        Transaction1_End = 0x00000002,

        /// <summary>
        /// 処理２は終了している
        /// </summary>
        Transaction2_End = 0x00000003,
    }

    public enum ReturnCode : uint
    {
        /// <summary>
        /// 正常終了
        /// </summary>
        Success = 0x00000000,

        /// <summary>
        /// 異常終了
        /// </summary>
        Error = 0x00000010,
    }
}
