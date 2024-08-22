public class Solution {
    public int FindComplement(int n) {
          int l = (int)Math.Floor(Math.Log2(n))+1 ;//3 length of thy binary number --> 101
 
  int msk = (1 << l);// 8 because 1 shift by 3 -- 1000 so i need the zeroos to be 1 so 7 is 0111 where i need number of ones
  // equal the length if original number
  msk -= 1; // 7 
  int ans = msk ^ n;// 7 -> 0111 xor 5 ->101 ---> 010 which is 2
       return ans;
    }
}