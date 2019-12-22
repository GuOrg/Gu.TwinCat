# Gu.TwinCat
For communication with Beckhoff TwinCAT PLC

## Sample

```cs
public sealed class Plc : IDisposable
{
    private readonly AdsClient client;
    private readonly ReadFromAdsSymbol<int, int> value3 = SymbolFactory.ReadInt32("Plc.Value3");
    private readonly ReadFromAdsSymbol<float, Angle> value4 = SymbolFactory.ReadSingle("Plc.Value4", x => Angle.FromDegrees(x));
    private readonly WriteToAdsSymbol<int, int> value5 = SymbolFactory.WriteInt32("Plc.Value5");
    private readonly WriteToAdsSymbol<float, Angle> value6 = SymbolFactory.WriteSingle<Angle>("Plc.Value6", x => x.Degrees);

    public Plc()
    {
        this.client = new AdsClient(
            new AutoReconnectSettings(
                address: new AmsAddress("1.2.3.4.5.6", 851),
                reconnectInterval: AdsTimeSpan.FromSeconds(1),
                inactiveSymbolHandling: InactiveSymbolHandling.Throw));

        this.Subscription1 = this.client.Subscribe(
            SymbolFactory.ReadInt32("Plc.Value1"),
            AdsTransMode.OnChange,
            AdsTimeSpan.FromMilliseconds(100));

        this.Subscription2 = this.client.Subscribe(
            SymbolFactory.ReadSingle(
                "Plc.Value2",
                x => Angle.FromDegrees(x)),
            AdsTransMode.OnChange,
            AdsTimeSpan.FromMilliseconds(100));
    }

    public Subscription<int, int> Subscription1 { get; }

    public Subscription<float, Angle> Subscription2 { get; }

    public int Value3() => this.client.Read(this.value3);

    public Angle Value4() => this.client.Read(this.value4);

    public void SetValue5(int value) => this.client.Write(this.value5, value);

    public void SetValue6(Angle value) => this.client.Write(this.value6, value);

    public void Dispose()
    {
        this.client.Dispose();
        this.Subscription1.Dispose();
        this.Subscription2.Dispose();
    }
}

public struct Angle
{
    public readonly float Degrees;

    public Angle(float degrees)
    {
        this.Degrees = degrees;
    }

    ...
    public static Angle FromDegrees(float value) => new Angle(value);
}
```
