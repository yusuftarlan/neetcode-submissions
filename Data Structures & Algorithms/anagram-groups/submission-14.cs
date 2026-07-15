public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach (char c in s)
            {
                count[c-'a']++;
            }
            string key = string.Join(",", count);
            if (!result.ContainsKey(key))
            {
                result[key] = new List<string>();
            }
            result[key].Add(s);
        }
        return result.Values.ToList<List<string>>();
    }
}