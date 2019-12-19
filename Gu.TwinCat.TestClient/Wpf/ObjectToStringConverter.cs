namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    public sealed class ObjectToStringConverter : IValueConverter
    {
        public static readonly ObjectToStringConverter Default = new ObjectToStringConverter();

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value switch
            {
                float[] xs => string.Join(", ", xs.Select(x => x.ToString(CultureInfo.InvariantCulture))),
                string s => $"\"{s}\"",
                bool s => s ? "true" : "false",
                null => "null",
                IFormattable x => x.ToString(null, CultureInfo.InvariantCulture),
                _ => value,
            };
        }

        object IValueConverter.ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotSupportedException($"{nameof(ObjectToStringConverter)} can only be used in OneWay bindings");
        }
    }
}
