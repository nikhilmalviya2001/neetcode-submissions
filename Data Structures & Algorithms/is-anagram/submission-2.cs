public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        var dict1 = makeDictionary(s);
        var dict2 = makeDictionary(t);

        if(dict1.Count != dict2.Count)
            return false;

        foreach(var pair in dict1)
        {
            if(!dict2.TryGetValue(pair.Key, out int value) || pair.Value != value)
                return false;
        }

        return true;
    }

    private Dictionary<char, int> makeDictionary(string str)
    {
        var dict = new Dictionary<char, int>();

        foreach(var x in str)
            dict[x] = dict.TryGetValue(x, out int cnt) ? cnt + 1 : 1;

        return dict;
    }
}
