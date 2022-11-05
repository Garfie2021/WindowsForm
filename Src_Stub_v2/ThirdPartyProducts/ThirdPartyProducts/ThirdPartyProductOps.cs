using System;
using System.Reflection;
using System.Threading;

namespace ThirdPartyProducts
{
    public static class ThirdPartyProductOps
    {
        private static Status _IsStarted = Status.NotStarted;

        public static Status IsStarted
        {
            get
            {
                Thread.Sleep(1000);

                return _IsStarted;
            }
        }

        /// <summary>
        /// 製品を起動
        /// </summary>
        public static ReturnCode Startup()
        {
            Thread.Sleep(1000);

            if (_IsStarted == Status.Started)
            {
                //既に起動してる
                return ReturnCode.Error;
            }
            else
            {
                _IsStarted = Status.Started;
                return ReturnCode.Success;
            }
        }

        /// <summary>
        /// 処理１
        /// </summary>
        public static ReturnCode Transaction1()
        {
            Thread.Sleep(1000);

            if (_IsStarted < Status.Started)
            {
                //起動していない
                return ReturnCode.Error;
            }

            _IsStarted = Status.Started;
            return ReturnCode.Success;
        }

        /// <summary>
        /// 処理２
        /// </summary>
        public static ReturnCode Transaction2()
        {
            Thread.Sleep(1000);

            if (_IsStarted < Status.Transaction2_End)
            {
                //処理１がまだ終わっていない
                return ReturnCode.Error;
            }

            return ReturnCode.Success;
        }

        /// <summary>
        /// 製品を停止
        /// </summary>
        public static ReturnCode Shutdown()
        {
            Thread.Sleep(1000);

            if (_IsStarted == Status.Started)
            {
                _IsStarted = Status.NotStarted;
                return ReturnCode.Success;
            }
            else
            {
                //既に停止してる
                return ReturnCode.Error;
            }
        }

    }
}