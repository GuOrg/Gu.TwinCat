namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    public class MaybeToStringConverter : IValueConverter
    {
        public static readonly MaybeToStringConverter Default = new MaybeToStringConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value switch
            {
                Maybe<bool> maybe => maybe.HasValue ? maybe.Value ? "true" : "false" : "missing",
                Maybe<int> maybe => maybe.HasValue ? maybe.Value.ToString(CultureInfo.InvariantCulture) : "missing",
                Maybe<uint> maybe => maybe.HasValue ? maybe.Value.ToString(CultureInfo.InvariantCulture) : "missing",
                Maybe<float> maybe => maybe.HasValue ? maybe.Value.ToString(CultureInfo.InvariantCulture) : "missing",
                Maybe<float[]> maybe => maybe.HasValue ? maybe.Value is null ? "null" : string.Join(", ", maybe.Value.Select(x => x.ToString(CultureInfo.InvariantCulture))) : "missing",
                Maybe<string> maybe => maybe.HasValue ? maybe.Value : "missing",
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
