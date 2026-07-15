public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> counts = new();
        for (int i = 0; i < strs.Count(); i++)
        {
            int[] count = new int[26];
            foreach (char c in strs[i].ToCharArray())
            {
                count[c - 97] += 1;
            }
            string hash = String.Join(".", count);
            if (!counts.ContainsKey(hash))
            {
                counts[hash] = new List<string>();
            }
            counts[hash].Add(strs[i]);
        }

        return counts.Values.ToList();
    }
}