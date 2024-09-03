public class Solution {
    public int GetLucky(string s, int k) {
         string tot = "";
 for(int i=0;i<s.Length;i++)
 {
     
     tot += (s[i] - 'a' +1).ToString(); // it return index from 0 to 25 si i add 1
   //  Console.WriteLine(tot);
 }
 for(int i=0;i<k;i++)
 {
     int sum = 0;
     for (int j = 0; j < tot.Length; j++)
     {

        sum += (tot[j] - '0' );
        
     }
    // Console.WriteLine(sum);
     tot = sum.ToString();
 }
 return (int.Parse(tot));
    }
}