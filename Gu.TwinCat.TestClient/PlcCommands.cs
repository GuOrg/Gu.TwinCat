namespace Gu.TwinCat.TestClient
{
    using System.Windows.Input;

    public static class PlcCommands
    {
        public static RoutedUICommand Read { get; } = new RoutedUICommand(nameof(Read), nameof(Read), typeof(PlcCommands));

        public static RoutedUICommand Write { get; } = new RoutedUICommand(nameof(Write), nameof(Write), typeof(PlcCommands));

        public static RoutedUICommand Subscribe { get; } = new RoutedUICommand(nameof(Subscribe), nameof(Subscribe), typeof(PlcCommands));
    }
}
