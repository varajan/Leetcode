using System;

public class ValidPalindrome {
    public bool IsPalindrome(string s) {
        if (s.Length == 0) return true;

        int i = -1;
        int j = s.Length;

        while (i < j)
        {
            while (i < s.Length - 1 && !isAlphaNumeric(s[++i]));
            while (j > 0            && !isAlphaNumeric(s[--j]));
            
            if (i < j && Char.ToLower(s[i]) != Char.ToLower(s[j])) return false;
        }

        return true;
    }
    
    private bool isAlphaNumeric(char x) => Char.IsDigit(x) || Char.IsLetter(x);
}
