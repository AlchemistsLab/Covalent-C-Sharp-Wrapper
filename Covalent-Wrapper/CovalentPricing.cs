namespace  Covalent_Wrapper{

public class CovalentPricing {
    
    private CovalentSession covSession;
    
    public CovalentPricing(CovalentSession covSession) {
        this.covSession = covSession;
    }
    
    //  GET pricing/historical_by_address/{chain_id}/{quote_currency}/{contract_address}/
    public string getHistoricalByAddress(CovalentNetworks cn, CovalentQuoteCurrency cqc, string contractAddress) {
        string req = ("pricing/historical_by_address/" 
                    + (cn.Value + ("/" 
                    + (cqc.Value + ("/" 
                    + (contractAddress + "/"))))));
        return this.covSession.query(req);
    }
    
    //  GET pricing/historical_by_addresses_v2/{chain_id}/{quote_currency}/{contract_addresses}/
    public string getHistoricalByAddressesV2(CovalentNetworks cn, CovalentQuoteCurrency cqc, string contractAddresses) {
        string req = ("pricing/historical_by_addresses_v2/" 
                    + (cn.Value + ("/" 
                    + (cqc.Value + ("/" 
                    + (contractAddresses + "/"))))));
        return this.covSession.query(req);
    }
    
    //  GET pricing/historical_by_addresses/{chain_id}/{quote_currency}/{contract_addresses}/
    public string getHistoricalByAddresses(CovalentNetworks cn, CovalentQuoteCurrency cqc, string contractAddresses) {
        string req = ("pricing/historical_by_addresses/" 
                    + (cn.Value + ("/" 
                    + (cqc.Value + ("/" 
                    + (contractAddresses + "/"))))));
        return this.covSession.query(req);
    }
    
    //  GET pricing/historical/{quote_currency}/{ticker_symbol}/
    public string getHistoricalPriceByTickerSymbol(CovalentQuoteCurrency cqc, string tickerSymbol) {
        string req = ("pricing/historical/" 
                    + (cqc.Value + ("/" 
                    + (tickerSymbol + "/"))));
        return this.covSession.query(req);
    }
    
    //  GET pricing/tickers/
    public string getSpotPrices(CovalentQuoteCurrency cqc) {
        string req = ("pricing/tickers/" 
                    + (cqc.Value + "/"));
        return this.covSession.query(req);
    }
    
    public string getSpotPricesByTickerSymbol(CovalentQuoteCurrency cqc, string tickersSymbols) {
        string req = ("pricing/tickers/" 
                    + (cqc.Value + ("/?tickers=" + tickersSymbols)));
        return this.covSession.query(req);
    }
    
    //  GET pricing/volatility/
    public string getPricesVolatility(CovalentQuoteCurrency cqc) {
        string req = ("pricing/volatility/" 
                    + (cqc.Value + "/"));
        return this.covSession.query(req);
    }
    
    public string getPricesVolatilityByTickerSymbol(CovalentQuoteCurrency cqc, string tickersSymbols) {
        string req = ("pricing/volatility/" 
                    + (cqc + ("/?tickers=" + tickersSymbols)));
        return this.covSession.query(req);
    }
}
}