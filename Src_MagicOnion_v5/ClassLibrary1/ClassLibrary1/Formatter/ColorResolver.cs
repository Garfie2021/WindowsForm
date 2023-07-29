using MessagePack;
using MessagePack.Formatters;
using System.Drawing;

namespace ClassLibrary1.Interface
{
    public class ColorResolver : IFormatterResolver
    {
        public static IFormatterResolver Instance = new ColorResolver();

        public IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                if (typeof(T) == typeof(Color))
                {
                    formatter = (IMessagePackFormatter<T>)ColorFormatter.Instance;
                }
                else
                {
                    formatter = null;
                }
            }
        }
    }
}
