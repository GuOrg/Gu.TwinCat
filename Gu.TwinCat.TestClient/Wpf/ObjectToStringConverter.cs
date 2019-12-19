namespace Gu.TwinCat.TestClient
{
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
                null => "null",
                _ => value,
            };
        }

        object IValueConverter.ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotSupportedException($"{nameof(ObjectToStringConverter)} can only be used in OneWay bindings");
        }
    }
}
