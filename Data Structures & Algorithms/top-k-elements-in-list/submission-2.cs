public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> dict = new();
        foreach (int num in nums)
        {
            if (!dict.ContainsKey(num))
                dict[num] = 0;
            dict[num]++;
        }

        PriorityQueue<int, int> queue = new();
        foreach (var kv in dict)
        {
            queue.Enqueue(kv.Key, kv.Value);
            if (queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        int[] result = new int[queue.Count];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = queue.Dequeue();
        }
        return result;
    }
}