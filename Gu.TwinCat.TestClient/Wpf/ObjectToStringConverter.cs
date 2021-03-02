namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    [ValueConversion(typeof(object), typeof(string))]
    public sealed class ObjectToStringConverter : IValueConverter
    {
        public static readonly ObjectToStringConverter Default = new ObjectToStringConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value switch
            {
                float[] xs => string.Join(", ", xs.Select(x => x.ToString(CultureInfo.InvariantCulture))),
                string s => $"\"{s}\"",
                bool s => s ? "true" : "false",
                null => "null",
                IFormattable x => x.ToString(null, CultureInfo.InvariantCulture),
                TestStruct x => $"{{ BOOL: {x.BOOL}, UDINT: {x.UDINT}, BYTE: {x.BYTE}, UINT: {x.UINT}}}",
                _ => value,
            };
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException($"{nameof(ObjectToStringConverter)} can only be used in OneWay bindings");
        }
    }
}
