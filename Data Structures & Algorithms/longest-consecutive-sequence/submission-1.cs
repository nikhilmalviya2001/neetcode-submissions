public class Solution {
    public int LongestConsecutive(int[] nums) {

        // 1. Making a Hashset of the given array, for removing the duplicate elements.
        var hashset = new HashSet<int>(nums);
        var longest = 0;

        foreach(var num in hashset)
        {
            if(hashset.Contains(num-1))
                continue;

            //var current = num;
            var length = 0;

            while(hashset.Contains(num + length))
            {
                //current++;
                length++;
            }

            if(length > longest)
                longest = length;    
        }

        return longest;
    }
}
