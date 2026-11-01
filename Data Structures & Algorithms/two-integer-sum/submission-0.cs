public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seem = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];

            if(seem.TryGetValue(need, out int j))
                return new[] {j, i};

            seem[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
