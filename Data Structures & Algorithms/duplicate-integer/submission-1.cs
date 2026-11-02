public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();

        foreach(var x in nums)
            dict[x] = dict.TryGetValue(x, out int cnt) ? cnt + 1 : 1;

        if(nums.Length != dict.Count)
            return true;

        return false;
    }
}