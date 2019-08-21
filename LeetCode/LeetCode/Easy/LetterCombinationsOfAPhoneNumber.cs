public class LetterCombinationsOfAPhoneNumber {
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string> {""};
        
        foreach (var digit in digits)
        {
            var newResult = new List<string>();
            var keys = GetKeyChars(digit);
            
            foreach (var key in keys)
                foreach (var x in result)
                    newResult.Add(x + key);
            
            result = newResult;
        }
        
        return result.Where(i => i != "").ToList();
    }
    
    private string GetKeyChars(char key){
        switch (key)
        {
            case '2': return "abc";
            case '3': return "def";
            case '4': return "ghi";
            case '5': return "jkl";
            case '6': return "mno";
            case '7': return "prsq";
            case '8': return "tuv";
            case '9': return "wxyz";
        }
        
        return null;
    }
}
