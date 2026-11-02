public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int longest = 0;

        foreach(var num in set)
        {
            if(set.Contains(num - 1))
                continue;       // Skips the num, not the num to start. 

            int length = 0;
            while(set.Contains(num + length))
                length++;

            longest = Math.Max(longest, length);
        }

        return longest;
    }
}
