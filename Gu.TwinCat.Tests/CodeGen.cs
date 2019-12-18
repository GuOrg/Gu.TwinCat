namespace Gu.TwinCat.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    public static class CodeGen
    {
        [Test]
        public static void METHOD()
        {
            Console.WriteLine(string.Join(", ", typeof(bool).Assembly.GetTypes().Where(x => x.IsPrimitive).Select(x => $"\"{x.Name}\"")));
        }
    }
}
