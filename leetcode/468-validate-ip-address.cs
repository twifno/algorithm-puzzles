//https://leetcode.com/problems/validate-ip-address/

public class Solution {
    public string ValidIPAddress(string IP) {
        if(IsIPv4(IP)) return "IPv4";
        if(IsIPv6(IP)) return "IPv6";
        return "Neither";
    }
    
    private bool IsIPv4(string IP) {
        string[] ips = IP.Split('.');
        if(ips.Length != 4) return false;
        for(int i = 0; i < ips.Length; i++){
            if(!IsIPv4Num(ips[i])) return false;
        }
        return true;
    }
    
    private bool IsIPv4Num(string s){
        if(s.Length < 1 || s.Length > 3) return false;
        if(s[0] == '0' && s != "0") return false;
        foreach(char c in s) if(c < '0' || c > '9') return false;
        int n = Int32.Parse(s);
        if(n < 0 || n > 255) return false;
        return true;
    }
    
    private bool IsIPv6(string IP){
        string[] ips = IP.Split(':');
        if(ips.Length != 8) return false;
        for(int i = 0; i < ips.Length; i++){
            if(!IsIPv6Num(ips[i])) return false;
        }
        return true;
    }
    
    private bool IsIPv6Num(string s){
        if(s.Length < 1 || s.Length > 4) return false;
        foreach(char c in s) {
            if((c < '0' || c > '9') 
              && (c < 'a' || c > 'f')
              && (c < 'A' || c > 'F')) return false;
        }
        return true;
    }
}
