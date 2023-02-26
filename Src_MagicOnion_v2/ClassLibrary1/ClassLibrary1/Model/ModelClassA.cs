using MessagePack;

namespace ClassLibrary1.Model
{
    [MessagePackObject]
    public class ModelClassA
    {
        [Key("IntA")] 
        public int IntA { get; set; }

        [Key("StringA")] 
        public string StringA { get; set; }
    }
}
