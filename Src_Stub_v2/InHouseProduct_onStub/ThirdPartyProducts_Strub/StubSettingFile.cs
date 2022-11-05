using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThirdPartyProducts
{
    public static class StubSettingFile
    {
        private static readonly string StubSettingListFileName = Path.GetTempPath() + @"StubSettingList.json";
        private static JsonSerializerOptions _JsonSerializerOptions = new JsonSerializerOptions()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };

        public static void Write(List<StubSetting> stubSettingList)
        {
            var jsonData = JsonSerializer.Serialize(stubSettingList, _JsonSerializerOptions);
            File.WriteAllText(StubSettingListFileName, jsonData);
        }

        public static ReturnCode GetErrorCode(string classname, string methodname)
        {
            if (!File.Exists(StubSettingListFileName))
            {
                return ReturnCode.Success;
            }

            var jsonData = File.ReadAllText(StubSettingListFileName);

            var stubSettingList = JsonSerializer.Deserialize<List<StubSetting>>(jsonData, _JsonSerializerOptions);

            return stubSettingList.First(x => x.ClassName == classname && x.MethodName == methodname).ReturnCode;
        }
    }
}
