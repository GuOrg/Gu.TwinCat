namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class MaybeToStringConverter : IValueConverter
    {
        public static readonly MaybeToStringConverter Default = new MaybeToStringConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value switch
            {
                Maybe<float> maybe => maybe.HasValue ? maybe.Value.ToString(CultureInfo.InvariantCulture) : "missing",
                null => "null",
                _ => value.ToString(),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
