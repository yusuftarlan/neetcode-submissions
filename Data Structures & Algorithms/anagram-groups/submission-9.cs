public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>(strs.Length);

        foreach (string word in strs)
        {
            string key = CreateKey(word);

            if (groups.TryGetValue(key, out var list))
            {
                list.Add(word);
            }
            else
            {
                groups[key] = new List<string> { word };
            }
        }

        return groups.Values.ToList();
    }

    private string CreateKey(string word)
    {
        int[] counts = new int[26];
        foreach (char ch in word)
        {
            counts[ch - 'a']++;
        }

        var sb = new StringBuilder(52); // 26 harf + en fazla 26 sayı basamağı
        for (int i = 0; i < 26; i++)
        {
            sb.Append((char)('a' + i));
            sb.Append(counts[i]);
        }

        return sb.ToString();
    }
}