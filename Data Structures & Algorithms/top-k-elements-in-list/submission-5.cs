public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        // 1. Making the Dictionary of Numbers in nums array for the frequency of them.
        foreach(var num in nums)
            dict[num] = dict.TryGetValue(num, out int cnt) ? cnt + 1 : 1;

        // 2. Bucketing the List of Numbers for all the possible frequencies of numbers in given array.
        var buckets = new List<int>[nums.Length + 1];
        foreach(var pair in dict)
        {
            var freq = pair.Value;
            if(buckets[freq] == null)
                buckets[freq] = new List<int>();
            buckets[freq].Add(pair.Key);
        }

        // 3. Filtering out the Top K most frequent number starting from the highest possible frequency to lowest frequency.
        var result = new List<int>();
        for(int f = buckets.Length - 1; f >= 1 && result.Count < k; f--)
        {
            if(buckets[f] == null) 
                continue; 

            foreach(var num in buckets[f])
            {
                result.Add(num);
                if(result.Count == k) 
                    break;
            }
        }

        return result.ToArray();
    }
}
