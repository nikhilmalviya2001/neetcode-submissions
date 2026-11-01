public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
                return false;
        
        var dict1 = makeDict(s);
        var dict2 = makeDict(t);

        if (dict1.Count != dict2.Count)
            return false;

        foreach(var pair in dict1)
        {
            if(!dict2.TryGetValue(pair.Key, out int Val) || pair.Value != Val)
                return false;
        }
        return true;
    }

    public Dictionary<char, int> makeDict(string str)
    {
        Dictionary<char, int> dicStr = new Dictionary<char, int>();

        foreach(var x in str)
        {
            dicStr[x] = dicStr.TryGetValue(x, out int count) ? count + 1 : 1;
        }

        return dicStr;
    }
}
