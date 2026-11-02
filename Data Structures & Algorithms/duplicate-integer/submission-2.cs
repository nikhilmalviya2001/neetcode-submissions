public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashset = new HashSet<int>();

        foreach(var x in nums)
        {
            if(!hashset.Add(x))
                return true;
        }

        return false;
    }
}