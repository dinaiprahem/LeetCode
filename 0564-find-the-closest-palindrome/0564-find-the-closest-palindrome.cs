public class Solution {
    public string NearestPalindromic(string x) {
         //if number from one digit -> 9 palindrome = 8 , 7 (6 or 8) -> 6
 //129 --> there is 5 cases 
 //1- so it is 3 digit so odd number of digits so i will remain the middle number (2) and take first half
 //without the least significant bit in it which is 12-->2 so i will reverse all without it (1) and make it as second
 // half  ----> 121
 //2- add one to least significant bit in fisrt half and reverse the number 12--> 13   --> 131
 //3- subtract one to least significant bit in fisrt half and reverse the number 11--> 11   --> 111
 // decrease the digit of the number from 3 digit to two digit (10^2)-1=  99
 // increase the digit of the number from 3 digit to 4 digit (10^3)+1=  1001
 //129-->131

 // 943121
 //1-half -> 943 -> n=6 so even  --> reverse the half 349 then (half + reverse half) = 943349
 //2-add 1 > 944 ->reverse = 449 --> 944449
 //3-subtract -> 942 -> n=6 so even  --> reverse the half 249 then (half + reverse half) = 942249
 // decrease digits --> 99999
 // increase -->1000001
 //compare from all (943349 smallest)

 //103--> 101 from 1st case not 5th case

 int l = x.Length;
 if (l == 1)
 {
     int s = int.Parse(x) - 1;
     string ans = s.ToString();
     return ans;
 }
 long original = long.Parse(x);
 long increaseDigits = (long)(Math.Pow(10, l) + 1);//1001 l=3
 long decreaseDigits = (long)(Math.Pow(10, l-1) - 1);//99
 long half =long.Parse( x.Substring(0, (l + 1) / 2)); // fisrt half 
 long same = palindrome(half, l % 2 == 0); // reversed number with same half with check is even digits or odd
 long greater = palindrome(half+1, l % 2 == 0);
 long smaller = palindrome(half-1, l % 2 == 0);
 long[] arr = new long[] { increaseDigits, same, greater, smaller, decreaseDigits };
 
 Array.Sort(arr);
 /*foreach (var item in arr)
 {
     Console.WriteLine(item);
 }*/
 long closest = long.MaxValue;
 foreach (var item in arr)
 {
     if (item == original) continue;
     if (Math.Abs(item - original) < Math.Abs(closest-original))
     {
         closest = item; // smaller closest one 
     }
     
 }
 return closest.ToString();

    }
     static long palindrome(long half , bool even)
 {
     string ans="";
     if(even)
     {
         ans = half.ToString() + new string (half.ToString().Reverse().ToArray()); // reverse return char of array not string

     }
     else
     {
         string x = half.ToString();
         ans = half.ToString() + new string(x.Substring(0,x.Length-1).Reverse().ToArray());
     }

     return long.Parse(ans);
 }

}