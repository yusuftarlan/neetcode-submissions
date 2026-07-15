public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int> control = new();
        
        foreach(int num in nums)
        {
            if(!control.Add(num))
            {
                return true;
            }
        }

        return false;
        
    }
}