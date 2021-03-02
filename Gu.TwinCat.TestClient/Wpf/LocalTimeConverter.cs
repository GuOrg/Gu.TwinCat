namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Windows.Data;

    [ValueConversion(typeof(DateTimeOffset), typeof(DateTime))]
    [ValueConversion(typeof(DateTime), typeof(DateTime))]
    public sealed class LocalTimeConverter : IValueConverter
    {
        public static readonly LocalTimeConverter Default = new LocalTimeConverter();

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value switch
            {
                DateTimeOffset x => x.LocalDateTime,
                DateTime x => x.ToLocalTime(),
                _ => throw new ArgumentException("Expected date time.", nameof(value))
            };
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException($"{nameof(LocalTimeConverter)} can only be used in OneWay bindings");
        }
    }
}
