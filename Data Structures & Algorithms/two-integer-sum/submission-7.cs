public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new();

        for(int i = 0; i< nums.Length; i ++)
        {
            int diff = target - nums[i];
            if(dict.ContainsKey(diff))
            {
                return [dict[diff], i];
            }
            else{
                dict[nums[i]] = i;
            }
        }
        return null;
    }
}
