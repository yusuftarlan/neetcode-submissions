public class Solution {
    public bool IsAnagram(string s, string t) {
        int s_len = s.Length;
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> s_dict = new();
        
        for(int i = 0; i < s.Length ; i++)
        {
            if(!s_dict.ContainsKey(s[i]))
            {
                s_dict[s[i]] = 0;
            }
            s_dict[s[i]]++;
        }

        for(int i = 0; i < t.Length ; i++)
        {
            if(!s_dict.TryGetValue(t[i], out int count)){
                return false;
            }
            if(count == 0)
            {
                return false;
            }
            s_dict[t[i]] = count - 1;
        }

        return true;

        
    }
}
