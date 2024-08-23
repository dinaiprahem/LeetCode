public class Solution {
    public string FractionAddition(string x) {
         int n = 0, d = 1;
 int i = 0;
 while (i < x.Length)
 {
     int sign = 1;
     if (x[i] == '+' || x[i]=='-')
     {
         if (x[i] == '-')
         {
             sign = -1;
            
         }
         else sign = 1;
         i++;

     }
        //-5/2+10/3+7/9
   int num = 0;
   while (i < x.Length && char.IsDigit(x[i]))
   {
       num = 10*num + (x[i] - '0'); //if number greater than 9 so i must take it all as 10 
       i++;
   }
   //to skip /
   i++;
//  Console.WriteLine("num is"+num + " x[i]" + x[i]);
   int deno = 0;
       
   while (i < x.Length && char.IsDigit(x[i]))
   {
       deno = 10 * deno + (x[i] - '0'); //if number greater than 9 so i must take it all as 10 
       i++;
   }
  // Console.WriteLine("deno is" + deno);

     num *= sign;
     n = num * d + n * deno;//numerator (-1*1+0*2)=-1
     d = d * deno;//denomerator 1*2=2

     int CD = gcd(Math.Abs(n), d);
     n /= CD; // to give the simplified fraction
     d /= CD;
     
     

 }
 string res = $"{n}/{d}";
 return res;
           
    }
       static int gcd(int a, int b)//12  16 = 4
   {
       if (b == 0) return a;
       else return gcd(b, a % b);
   }
   //gcd(16,12%16 = 12) 
   //gcd (12,16%12 = 4)
   //gcd(4,12%4=0) so b=0 so return a = 4;
}