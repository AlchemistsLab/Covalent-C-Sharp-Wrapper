namespace  Covalent_Wrapper{

public class CovalentResponse {
    
    private string data;
    
    private bool error;
    
    private string error_message;
    
    private string error_code;
    
    public bool isError() {
        return this.error;
    }
    
    public void setError(bool error) {
        this.error = error;
    }
    
    public string getData() {
        return this.data;
    }
    
    public void setData(string data) {
        this.data = data;
    }
    
    public string getError_message() {
        return this.error_message;
    }
    
    public void setError_message(string error_message) {
        this.error_message = error_message;
    }
    
    public string getError_code() {
        return this.error_code;
    }
    
    public void setError_code(string error_code) {
        this.error_code = error_code;
    }
}
}