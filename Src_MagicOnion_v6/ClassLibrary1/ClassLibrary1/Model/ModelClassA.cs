using MessagePack;
using System.Drawing;

namespace ClassLibrary1.Model
{
    [MessagePackObject]
    public class ModelClassA
    {
        [Key(0)] 
        public int IntA { get; set; }

        [Key(1)] 
        public string StringA { get; set; }

        [Key(2)]
        public Color ColorA { get; set; }
    }
}
