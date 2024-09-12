public class Solution {
    public int CountConsistentStrings(string allowed, string[] arr) {
         int r = 0;
 for( int x =0 ; x < arr.Length; x++)
 {
     bool c = true;
     for(int i = 0; i < arr[x].Length;i++)
     {
         //  Console.Write(arr[x][i]);
         if (!allowed.Contains(arr[x][i]))
             {
             c = false;
             break;
             }
         
     }
     if (c) r++;
    
 }
 //Console.WriteLine(r);
 return r;
    }
}