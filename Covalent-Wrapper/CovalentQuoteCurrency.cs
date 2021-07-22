namespace  Covalent_Wrapper{
public class CovalentQuoteCurrency {
    private CovalentQuoteCurrency(string value) { Value = value; }
    public string Value { get; private set; }

    public static CovalentQuoteCurrency usd { get { return new CovalentQuoteCurrency("usd"); } }
    public static CovalentQuoteCurrency cad { get { return new CovalentQuoteCurrency("cad"); } }
    public static CovalentQuoteCurrency inr { get { return new CovalentQuoteCurrency("cad"); } }
    public static CovalentQuoteCurrency eth { get { return new CovalentQuoteCurrency("eth"); } }
    public static CovalentQuoteCurrency eur { get { return new CovalentQuoteCurrency("eur"); } }
    
}
}