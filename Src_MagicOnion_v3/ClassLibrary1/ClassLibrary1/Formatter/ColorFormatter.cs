using MessagePack;
using MessagePack.Formatters;
using System.Drawing;

namespace ClassLibrary1.Interface
{
    public class ColorFormatter : IMessagePackFormatter<Color>
    {
        public static readonly IMessagePackFormatter<Color> Instance = new ColorFormatter();

        ColorFormatter() { }

        public void Serialize(ref MessagePackWriter writer, Color value, MessagePackSerializerOptions options)
        {
            int ival = value.ToArgb();
            writer.WriteInt32(ival);
        }

        public Color Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            var cval = reader.ReadInt32();
            return Color.FromArgb(cval);
        }
    }
}
