namespace  Covalent_Wrapper{


public class CovalentClassB {
    
    private CovalentSession covSession;
    
    public CovalentClassB(CovalentSession covSession) {
        this.covSession = covSession;
    }
    
    //  GET {chain_id}/address/{address}/stacks/aave_v2/balances/
    public string getAaveV2AddressBalances(CovalentNetworks cn, string address) {
        string req = (cn.Value + ("/address/" 
                    + (address + "/stacks/aave_v2/balances/")));
        return this.covSession.query(req);
    }
    
    //  GET {chain_id}/address/{address}/stacks/sushiswap/acts/
    public string getSushiswapAddressExchangeLiquidityTransactions(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string swaps) {
        string req = (cn.Value + ("/address/" 
                    + (address + "/stacks/sushiswap/acts/")));
        string[] p = new string[] {
                "quote-currency",
                "swaps"};
        object[] paramValues = new object[] {
                cqc.Value,
                swaps};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/address/{address}/stacks/sushiswap/balances/
    public string getSushiswapAddressExchange(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc) {
        string req = (cn.Value + ("/address/" 
                    + (address + "/stacks/sushiswap/balances/")));
        string[] p = new string[] {
                "quote-currency"};
        object[] paramValues = new object[] {
                cqc.Value};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/networks/aave_v2/assets/
    public string getAaveV2NetworkAssets(CovalentNetworks cn) {
        string req = (cn.Value + "/networks/aave_v2/assets/");
        return this.covSession.query(req);
    }
    
    //  GET {chain_id}/networks/sushiswap/assets/
    public string getSushiswapNetworkAssets(CovalentNetworks cn, string tickers) {
        string req = (cn.Value + "/networks/aave_v2/assets/");
        string[] p = new string[] {
                "tickers"};
        object[] paramValues = new object[] {
                tickers};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET 1/address/{address}/stacks/aave_v2/balances/
    public string getAaveV2AddressBalance(CovalentNetworks cn, string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/aave_v2/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/aave/balances/
    public string getAaveAddressBalance(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/aave/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/balancer/balances/
    public string getBalancerExchangeAddressBalance(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/balancer/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/compound/acts/
    public string getCompoundAddressActivity(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/compound/acts/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/compound/balances/
    public string getCompoundAddressBalances(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/compound/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/curve/balances/
    public string getCurveAddressBalances(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/curve/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/farming/positions/
    public string getFarminAddressStats(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/farming/positions/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/uniswap_v1/balances/
    public string getUniswapV1AddressExchangeBalances(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/uniswap_v1/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET 1/address/{address}/stacks/uniswap_v2/acts/
    public string getUniswapV2AddressLquidityTransactions(string address, string swaps) {
        string req = ("1/address/" 
                    + (address + "/stacks/uniswap_v2/acts/"));
        string[] p = new string[] {
                "swaps"};
        object[] paramValues = new object[] {
                swaps};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET 1/address/{address}/stacks/uniswap_v2/balances/
    public string getUniswapV2AddressExchangeBalances(string address) {
        string req = ("1/address/" 
                    + (address + "/stacks/uniswap_v2/balances/"));
        return this.covSession.query(req);
    }
    
    //  GET networks/aave/assets/
    public string getAaveNetworkAssets() {
        string req = "1/networks/aave/assets/";
        return this.covSession.query(req);
    }
    
    //  GET 1/networks/augur/affiliate_fee/
    public string getAugurMarketAffiliateFeeDivisors() {
        string req = "1/networks/augur/affiliate_fee/";
        return this.covSession.query(req);
    }
    
    //  GET 1/networks/compound/assets/
    public string getCompoundNetworkAssets() {
        string req = "1/networks/compound/assets/";
        return this.covSession.query(req);
    }
    
    //  GET 1/networks/uniswap_v2/assets/
    public string getUniswapV2NetworkAssets() {
        string req = "1/networks/uniswap_v2/assets/";
        return this.covSession.query(req);
    }
    
    //  GET 56/address/{address}/stacks/pancakeswap_v2/balances/
    public string getPancakeswapV2AddressExchangeBalances(string address, CovalentQuoteCurrency cqc) {
        string req = ("56/address/" 
                    + (address + "/stacks/pancakeswap_v2/balances/"));
        string[] p = new string[] {
                "quote-currency"};
        object[] paramValues = new object[] {
                cqc.Value};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET 56/address/{address}/stacks/pancakeswap/acts/
    public string getPancakeswapV2AddressExchangeLiquidityTransactions(string address, CovalentQuoteCurrency cqc, string swaps) {
        string req = ("56/address/" 
                    + (address + "/stacks/pancakeswap/acts/"));
        string[] p = new string[] {
                "quote-currency",
                "swaps"};
        object[] paramValues = new object[] {
                cqc.Value,
                swaps};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET 56/address/{address}/stacks/pancakeswap/balances/
    public string getPancakeswapAddressExchangeBalances(string address, CovalentQuoteCurrency cqc) {
        string req = ("56/address/" 
                    + (address + "/stacks/pancakeswap/balances/"));
        string[] p = new string[] {
                "quote-currency"};
        object[] paramValues = new object[] {
                cqc.Value};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET 56/networks/pancakeswap_v2/assets/
    public string getPancakeswapV2NetworkAssets(string tickers, string contract_addresses) {
        string req = "56/networks/pancakeswap_v2/assets/";
        string[] p = new string[] {
                "tickers",
                "contract-addresses"};
        object[] paramValues = new object[] {
                tickers,
                contract_addresses};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET 56/networks/pancakeswap_v2/assets/{address}/
    public string getPancakeswapV2NetworkAssetsByAddress(string addresses) {
        string req = ("56/networks/pancakeswap_v2/assets/" 
                    + (addresses + "/"));
        return this.covSession.query(req);
    }
    
    //  GET 56/networks/pancakeswap/assets/
    public string getPancakeswapNetworkAssets(string tickers) {
        string req = "56/networks/pancakeswap/assets/";
        string[] p = new string[] {
                "tickers"};
        object[] paramValues = new object[] {
                tickers};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
}

}