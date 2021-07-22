namespace Covalent_Wrapper{
    public class StringUtil {
        public static string ConcatUrlParams(string url,string[] p,object[] paramValues) {
            if(p.Length != paramValues.Length) return url;
            for(int i=0; i< p.Length; i++) {
                string separator="&";
                if(i==0)
                    separator="?";
                url+=separator+p[i]+"="+paramValues[i];
            }
            return url;
        }
    }
}