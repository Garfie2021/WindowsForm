using MessagePack;
using System.Drawing;

namespace ClassLibrary1.Model
{
    [MessagePackObject]
    public class ModelClassA
    {
        [Key("IntA")] 
        public int IntA { get; set; }

        [Key("StringA")] 
        public string StringA { get; set; }

        [Key("ColorA")]
        public Color ColorA { get; set; }
    }
}
