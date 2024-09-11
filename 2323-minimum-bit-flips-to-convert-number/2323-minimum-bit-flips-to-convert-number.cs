public class Solution {
    public int MinBitFlips(int start, int goal) {
     int x= start^goal;   
 int r = 0;
 while(x>0)
 {
     if ((x &1 )== 1 ) r++;
     x >>= 1;
 }
 return r;
    }
}