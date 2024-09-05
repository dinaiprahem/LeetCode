public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
  
        int m = rolls.Length;
        int total_sum = mean * (n + m);
        
        int current_sum = 0;
        foreach (int roll in rolls) {
            current_sum += roll;
        }
        
 
        int missing_sum = total_sum - current_sum;
        
       
        if (missing_sum < n || missing_sum > 6 * n) {
            return new int[0];  // No solution exists
        }
        
        int[] result = new int[n];
        int avg = missing_sum / n;
        int remainder = missing_sum % n;
        
       
        for (int i = 0; i < n; i++) {
            result[i] = avg + (i < remainder ? 1 : 0);
        }
        
        return result;
    }
}
