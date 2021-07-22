namespace  Covalent_Wrapper{
public class CovalentNetworks {
    private CovalentNetworks(string value) { Value = value; }
    public string Value { get; private set; }

    public static CovalentNetworks Ethereum { get { return new CovalentNetworks("1"); } }
    public static CovalentNetworks Polygon { get { return new CovalentNetworks("137"); } }
    public static CovalentNetworks Avalanche { get { return new CovalentNetworks("43114"); } }
    public static CovalentNetworks BinanceSmartChain { get { return new CovalentNetworks("56"); } }
    public static CovalentNetworks FantomOpera { get { return new CovalentNetworks("250"); } }
    public static CovalentNetworks TestnetPolygonMaticMumbai { get { return new CovalentNetworks("80001"); } }
    public static CovalentNetworks TestnetFujiCChain { get { return new CovalentNetworks("43113"); } }
    public static CovalentNetworks TestnetKovan { get { return new CovalentNetworks("42"); } }
    public static CovalentNetworks TestnetBinanceSmartChain { get { return new CovalentNetworks("97"); } }
    public static CovalentNetworks TestnetMoonbaseAlpha { get { return new CovalentNetworks("1287"); } }
    public static CovalentNetworks TestnetFantom { get { return new CovalentNetworks("4002"); } }
}
}