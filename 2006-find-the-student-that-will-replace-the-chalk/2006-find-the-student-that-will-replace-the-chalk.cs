public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
       
    int n = chalk.Length;
    long totalChalk = 0;

    // Calculate the total chalk used in one complete cycle
    for (int i = 0; i < n; i++)
    {
        totalChalk += chalk[i];
    }

    // Reduce k to the remaining chalk needed after complete cycles
    k = (int)(k % totalChalk);

    for (int i = 0; i < n; i++)
    {
        if (k < chalk[i])
        {
            return i;
        }
        k -= chalk[i];
    }
    // This point should not be reached
    throw new InvalidOperationException("Unexpected state.");

}
    
}