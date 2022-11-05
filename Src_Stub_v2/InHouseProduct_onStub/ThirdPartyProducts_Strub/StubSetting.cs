using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyProducts
{
    [Serializable]
    public class StubSetting
    {
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public ReturnCode ReturnCode { get; set; }
    }
}
