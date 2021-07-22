namespace  Covalent_Wrapper{
   
    public class CovalentClassA {
    
    private CovalentSession covSession;
    
    public CovalentClassA(CovalentSession covSession) {
        this.covSession = covSession;
    }
    
    //  GET {chain_id}/address/{address}/balances_v2/
    public string getTokenBalancesForAddress(CovalentNetworks cn, string address, bool nft, bool noNftFetch, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/address/"+(address+"/balances_v2/")));
        string[] p = new string[] {
                "nft",
                "no-nft-fetch",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                nft?"true":"false",
                noNftFetch?"true":"false",
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
     //  GET {chain_id}/address/{address}/portfolio_v2/
    public string getHistoricalPortfolioValueOverTime(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/address/" 
                    + (address + "/portfolio_v2/")));
        string[] p = new string[] {
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/address/{address}/transactions_v2/
    public string getTransactions(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, bool block_signed_at_asc, bool no_logs, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/address/" 
                    + (address + "/transactions_v2/")));
        string[] p = new string[] {
                "block-signed-at-asc",
                "no-logs",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                block_signed_at_asc?"true":"false",
                no_logs?"true":"false",
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/address/{address}/transfers_v2/
    public string getERC20Transfers(CovalentNetworks cn, string address, string contract_address, CovalentQuoteCurrency cqc, bool block_signed_at_asc, bool no_logs, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value+ ("/address/" 
                    + (address + "/transfers_v2/")));
        string[] p = new string[] {
                "contract-address",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                contract_address,
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/block_v2/{block_height}/
    public string getBlock(CovalentNetworks cn, string blockHeight, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/block_v2/" 
                    + (blockHeight + "/")));
        string[] p = new string[] {
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/block_v2/{start_date}/{end_date}/
    public string getBlockHeights(CovalentNetworks cn, string start_date, string end_date, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/block_v2/" 
                    + (start_date + ("/" 
                    + (end_date + "/")))));
        string[] p = new string[] {
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/events/address/{address}/
    public string getLogEventsByContractAddress(CovalentNetworks cn, string address, string starting_block, string ending_block, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/events/address/" 
                    + (address + "/")));
        string[] p = new string[] {
                "starting-block",
                "ending-block",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                starting_block,
                ending_block,
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/events/topics/{topic}/
    public string getLogEventsByTopicHashes(CovalentNetworks cn, string topic, string secondary_topic, string starting_block, string ending_block, string sender_address, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/events/topics/" 
                    + (topic + "/")));
        string[] p = new string[] {
                "secondary-topic",
                "starting-block",
                "ending-block",
                "sender-address",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                secondary_topic,
                starting_block,
                ending_block,
                sender_address,
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/tokens/{address}/nft_metadata/{token_id}/
    public string getExternalNFTMetadata(CovalentNetworks cn, string address, string token_id, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/tokens/" 
                    + (address + ("/nft_metadata/" 
                    + (token_id + "/")))));
        string[] p = new string[] {
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/tokens/{address}/nft_token_ids/
    public string getNFTTokensIDs(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/tokens/" 
                    + (address + "/nft_token_ids/")));
        string[] p = new string[] {
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/tokens/{address}/nft_transactions/{token_id}/
    public string getNFTTransactions(CovalentNetworks cn, string address, string token_id, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/tokens/" 
                    + (address + ("/nft_transactions/" 
                    + (token_id + "/")))));
        string[] p = new string[] {
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/tokens/{address}/token_holders_changes/
    public string getChangesInTokenHolders(CovalentNetworks cn, string address, CovalentQuoteCurrency cqc, string starting_block, string ending_block, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/tokens/" 
                    + (address + "/token_holders_changes/")));
        string[] p = new string[] {
                "starting-block",
                "ending-block",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                starting_block,
                ending_block,
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/tokens/{address}/token_holders/
    public string getTokenHoldersASOfBlockHeight(CovalentNetworks cn, string address, string block_height, CovalentQuoteCurrency cqc, string starting_block, string ending_block, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/tokens/" 
                    + (address + "/token_holders/")));
        string[] p = new string[] {
                "starting-block",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                starting_block,
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/tokens/tokenlists/{id}/
    public string getAllContractMetaData(CovalentNetworks cn, string id, string block_height, CovalentQuoteCurrency cqc, string starting_block, string ending_block, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/tokens/tokenlists/" 
                    + (id + "/")));
        string[] p = new string[] {
                "starting-block",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                starting_block,
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET {chain_id}/transaction_v2/{tx_hash}/
    public string getTransaction(CovalentNetworks cn, string tx_hash, bool no_logs, CovalentQuoteCurrency cqc, string primer, string match, string group, string sort, int skip, int limit) {
        string req = (cn.Value + ("/transaction_v2/" 
                    + (tx_hash + "/")));
        string[] p = new string[] {
                "no-logs",
                "match",
                "group",
                "sort",
                "skip",
                "primer",
                "quote-currency",
                "limit"};
        object[] paramValues = new object[] {
                no_logs?"true":"false",
                match,
                group,
                sort,
                skip,
                primer,
                cqc.Value,
                limit};
        return this.covSession.query(StringUtil.ConcatUrlParams(req, p, paramValues));
    }
    
    //  GET chains/
    public string getAllChain() {
        string req = "chains/";
        return this.covSession.query(req);
    }
    
    //  GET chains/status/
    public string getAllChainStatuses() {
        string req = "chains/status/";
        return this.covSession.query(req);
    }
    }
}

