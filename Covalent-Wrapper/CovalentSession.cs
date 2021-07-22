using System;
using RestSharp;

namespace  Covalent_Wrapper{

public class CovalentSession {
    
    private string apiKey;
    
    private string format = "";
    
    private string fromDate = "";
    
    private string toDate = "";
    
    private int pageSize;
    
    private int pageNumber;
    
    private bool pricesAscending;
    
    private static string serverUrl = "https://api.covalenthq.com/v1/";
    
    public CovalentSession(string apiKey) {
        this.apiKey = apiKey;
        this.setFormat("json");
    }
    
    public CovalentSession(string apiKey, string format) {
        this.apiKey = apiKey;
        this.setFormat(format);
    }
    
    public string getKey() {
        return this.apiKey;
    }
    
    public void setKey(string apiKey) {
        this.apiKey = apiKey;
    }
    
    private bool isPricesAscending() {
        return this.pricesAscending;
    }
    
    private void setPricesAscending(bool pricesAscending) {
        this.pricesAscending = pricesAscending;
    }
    
    private int getPageNumber() {
        return this.pageNumber;
    }
    
    private void setPageNumber(int pageNumber) {
        this.pageNumber = pageNumber;
    }
    
    private int getPageSize() {
        return this.pageSize;
    }
    
    private void setPageSize(int pageSize) {
        this.pageSize = pageSize;
    }
    
    private string getToDate() {
        return this.toDate;
    }
    
    private void setToDate(string toDate) {
        this.toDate = toDate;
    }
    
    private string getFromDate() {
        return this.fromDate;
    }
    
    private void setFromDate(string fromDate) {
        this.fromDate = fromDate;
    }
    
    private string getFormat() {
        return this.format;
    }
    
    private void setFormat(string format) {
        this.format = format;
    }
    
    public string query(string requestURL) {
        string url = (serverUrl + requestURL);
        if (requestURL.Substring((requestURL.Length - 1)).Equals("/")) {
            url = (url + ("?key=" + this.apiKey));
        }
        else {
            url = (url + ("&key=" + this.apiKey));
        }
        
        if ((this.getFormat() != "")) {
            url = (url + ("&format=" + this.getFormat()));
        }
        
        if ((this.getFromDate() != "")) {
            url = (url + ("&from=" + this.getFromDate()));
        }
        
        if ((this.getToDate() != "")) {
            url = (url + ("&to=" + this.getToDate()));
        }
        
        if (this.isPricesAscending()) {
            url += "&prices-at-asc=true";
        }
        
        if ((this.getPageSize() > 0)) {
            url = (url + ("&page-size=" + this.getPageSize()));
        }
        
        if ((this.getPageNumber() > 0)) {
            url = (url + ("&page-number=" + this.getPageNumber()));
        }
        
        Console.WriteLine(url);
        
        var client = new RestClient(url);
        client.Timeout = -1;
        var request = new RestRequest(Method.GET);
        request.AddHeader("Authorization", "Basic Y2tleV86");
        //request.AlwaysMultipartFormData = true;
        IRestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
        return response.Content;
    }
}
}