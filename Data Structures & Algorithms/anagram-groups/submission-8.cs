public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs){
        Dictionary<string, List<string>> hashes = new();
        foreach(string word in strs)
        {
            string hash = Create_hash(word);
            if(hashes.ContainsKey(hash)){
                hashes[hash].Add(word);
            }
            else{

                hashes[hash] = new List<string>();
                hashes[hash].Add(word);
            }
        }
        List<List<string>> result = new();
        foreach(var kv in hashes)
        {
            result.Add(kv.Value);

        }
        return result;


        

        
        
    }
    public string Create_hash(string word)
        {
            int[] hash = new int[26];
            foreach (char ch in word)
            {
                
                if(hash[ch - 97]<9)
                hash[ch - 97]++;
                else
                hash[ch - 97]--;

            }
            return String.Join("", hash);
        }
}
