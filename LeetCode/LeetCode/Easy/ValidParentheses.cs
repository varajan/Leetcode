using System.Collections.Generic;
using System.Linq;

public class ValidParentheses {
    public bool IsValid(string s) {
        var bracketsQueue = "";
        var brackets = new Dictionary<char, int>{ {'(', 0}, {'{', 0}, {'[', 0} };
        
        foreach (var x in s){
            if ("({[".Contains(x))
            {
                brackets[x]++;
                bracketsQueue += x;
            }
            else
            {
                if (bracketsQueue.LastOrDefault() != GetOpenBracket(x)) return false;
                
                brackets[GetOpenBracket(x)]--;
                bracketsQueue = bracketsQueue.Substring(0, bracketsQueue.Length - 1);
                
                if (brackets.Any(bracket => bracket.Value < 0)) return false;
            }
        }
        
        return brackets.All(bracket => bracket.Value == 0);
        
        char GetOpenBracket(char bracket) => (char) (bracket > 50 ? bracket - 2 : bracket - 1);
    }
}
