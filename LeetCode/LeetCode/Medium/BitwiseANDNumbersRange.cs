public class BitwiseANDNumbersRange {
    public int RangeBitwiseAnd(int m, int n) {
        var result = m;
        var bites = GetBitesCount(m);
        var max = BytePow(bites);
        
        if (max < n) return 0;
        
        for (int i = m; i <= n && i > 0; i++)
        {
            result &= i;
            if (result == 0) break;
        }
        
        return result;
    }
    
    int BytePow(int bites)
    {
        int result = 1;
        for (int i = 0; i < bites; i++) result *= 2;
        return result < 0 ? int.MaxValue : result;
    }
    
    int GetBitesCount(int number)
    {
        var result = 0;
        
        while (number > 0)
        {
            result++;
            number /= 2;
        }
        
        return result;
    }
}
