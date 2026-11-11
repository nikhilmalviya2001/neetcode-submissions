public class Solution {
    public int LongestConsecutive(int[] nums) {

        // 1. Making a Hashset of the given array, for removing the duplicate elements.
        var hashset = new HashSet<int>(nums);
        var longest = 0;

        foreach(var num in hashset)
        {
            // 2. If any number has a number smaller than it, then skipping that element for longest sequence.
            if(hashset.Contains(num-1))
                continue;

            // 3. Declaring a length of sequence for each possible element.
            var length = 0;

            // 4. Checking for the next possible sequence of elements for a respective num element.
            while(hashset.Contains(num + length))
                length++;

            if(length > longest)
                longest = length;    
        }

        // 5. Returning the longest sequence of all.
        return longest;
    }
}
