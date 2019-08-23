public class BullsAndCows {
    public string GetHint(string secret, string guess) {
        int bulls = 0;
        int cows = 0;
        
        for (int i = secret.Length - 1; i > -1; i--)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
                secret = secret.Remove(i, 1);
                guess = guess.Remove(i, 1);
            }
        }
        
        for (int i = guess.Length - 1; i > -1; i--)
        {
            int index = secret.IndexOf(guess[i]);
            if (index >= 0)
            {
                secret = secret.Remove(index, 1);
                cows++;
            }
        }
        
        return bulls + "A" + cows + "B";
    }
}
