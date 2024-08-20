public class Solution {
    static int[,] dp = new int[101, 103];
    public int StoneGameII(int[] arr) {
for (int i = 0; i < dp.GetLength(0); i++)
{
    for (int j = 0; j < dp.GetLength(1); j++)
    {
        dp[i, j] = -1;
    }
}
int sum = 0;
foreach (var item in arr)
{
    sum += item;
}
int d = fun(0, 1, arr);
return (sum + d) / 2;
    }
     private static int fun(int i,int m, int[]arr)
 {
     
     if(i>=arr.Length)
     {
         return 0;
     }
     if (dp[i, m] != -1) return dp[i, m];
     int sum=0;
     int ans = int.MinValue;
     for (int j = 0; j < 2*m; j++)
     {
         if(i+j<arr.Length)
         {
             sum += arr[i + j];

         }
         ans = Math.Max(ans, sum - fun(i + j + 1, Math.Max(m, j + 1), arr));

     }
     

     return dp[i,m]=ans;

 }
}