public class Solution {
    public int[] GetConcatenation(int[] nums) {
        if(nums.Length <= 0)
            return Array.Empty<int>();

        int n = nums.Length;
        var result = new int[n * 2];
        
        for(int i = 0; i < n; i++)
        {
            result[i] = nums[i];
            result[i+n] = nums[i];
        }

        return result;
    }
}