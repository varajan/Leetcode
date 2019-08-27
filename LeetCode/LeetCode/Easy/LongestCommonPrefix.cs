using System.Linq;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = "";
        var word = strs.Any() ? strs[0] : string.Empty;
        
        for (int i = 0; i < word.Length; i++)
        {
            if (!strs.All(x => x.StartsWith(result + word[i])))
                break;
           
            result += word[i];
        }
        
        return result;
    }
}
