public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // 1. Making the Hash Table for storing the frequencies of all elements in array.
        foreach(var x in nums)
            freq[x] = freq.TryGetValue(x, out int cnt) ? cnt + 1 : 1;

        // 2. Storing the elements in buckets with their frequency
        var buckets = new List<int>[nums.Length + 1];
        foreach(var pair in freq)
        {
            var count = pair.Value;
            if(buckets[count] == null)
                buckets[count] = new List<int>();
            buckets[count].Add(pair.Key);
        }

        //3. Returning the Dynamic int List into Array of integer.
        var result = new List<int>();
        for(int i = buckets.Length - 1; i >= 1 && result.Count < k; i--)
        {
            if(buckets[i] == null)
                continue;

            foreach(var num in buckets[i])
            {
                result.Add(num);
                if(result.Count == k)
                    break;
            }
        }

        return result.ToArray();
    }
}
