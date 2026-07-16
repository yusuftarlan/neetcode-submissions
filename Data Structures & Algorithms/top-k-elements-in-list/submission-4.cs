public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new();
        List<int>[] list = new List<int>[nums.Length +1];

        for(int i = 0; i< list.Length; i++)
        {
            list[i] = new List<int>();
        }
        foreach (int num in nums)
        {
            if(freq.ContainsKey(num)) freq[num]++;
            else freq[num] = 1;
        }
        foreach(var kv in freq)
        {
            list[kv.Value].Add(kv.Key);
        }
        int[] result = new int [k];
        int index = 0;
        for(int i = list.Length - 1; i > 0 && index < k; i--)
        {
            foreach(int n in list[i])
            {
                result[index++] = n;
                if(index == k)
                {
                    return result;
                }
            }
        }
        return result;

        
    }
}
