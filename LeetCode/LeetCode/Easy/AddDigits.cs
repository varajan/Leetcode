public class AddDigits {
    public int AddDigits(int num) {
        while (num > 9) num = getSum(num);
        return num;
        
        int getSum(int x){
            int result = 0;
            
            while (x > 0)
            {
                result += x%10;
                x /= 10;
            }
            
            return result;
        }
    }
}
