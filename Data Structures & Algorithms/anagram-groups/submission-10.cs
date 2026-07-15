public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>(strs.Length);

        foreach (string word in strs)
        {
            Span<int> counts = stackalloc int[26];
            foreach (char c in word)
                counts[c - 'a']++;

            Span<char> keyChars = stackalloc char[26];
            for (int i = 0; i < 26; i++)
                keyChars[i] = (char)counts[i];

            string key = new string(keyChars);

            if (groups.TryGetValue(key, out var list))
                list.Add(word);
            else
                groups[key] = new List<string> { word };
        }

        return groups.Values.ToList();
    }
}