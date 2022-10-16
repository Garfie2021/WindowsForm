using System;
using System.Diagnostics;
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
                Debug.WriteLine("Call : " + typeof(ThirdPartyProductOps).Name + "." + MethodBase.GetCurrentMethod().Name);

                Thread.Sleep(1000);

                return _IsStarted;
            }
        }

        public static ReturnCode Startup()
        {
            Debug.WriteLine("Call : " + typeof(ThirdPartyProductOps).Name + "." + MethodBase.GetCurrentMethod().Name);

            Thread.Sleep(1000);

            return ReturnCode.Success;
        }

        public static ReturnCode Shutdown()
        {
            Debug.WriteLine("Call : " + typeof(ThirdPartyProductOps).Name + "." + MethodBase.GetCurrentMethod().Name);

            Thread.Sleep(1000);

            return ReturnCode.Success;
        }

        public static ReturnCode Transaction1()
        {
            Debug.WriteLine("Call : " + typeof(ThirdPartyProductOps).Name + "." + MethodBase.GetCurrentMethod().Name);

            Thread.Sleep(1000);

            return ReturnCode.Success;
        }

        public static ReturnCode Transaction2()
        {
            Debug.WriteLine("Call : " + typeof(ThirdPartyProductOps).Name + "." + MethodBase.GetCurrentMethod().Name);

            Thread.Sleep(1000);

            return ReturnCode.Success;
        }

    }
}