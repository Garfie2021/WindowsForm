using MessagePack;
using MessagePack.Formatters;
using System.Drawing;

namespace ClassLibrary1.Interface
{
    public class ColorFormatter : IMessagePackFormatter<Color>
    {
        public static readonly IMessagePackFormatter<Color> Instance = new ColorFormatter();

        public void Serialize(ref MessagePackWriter writer, Color value, MessagePackSerializerOptions options)
        {
            writer.WriteInt32(value.ToArgb());
        }

        public Color Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            return Color.FromArgb(reader.ReadInt32());
        }
    }
}
