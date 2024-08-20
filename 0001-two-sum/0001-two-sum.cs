public class Solution {
    public int[] TwoSum(int[] nums, int target) {
               int[] ans = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j=0;j<nums.Length;j++)
            {
                if (i==j)
                {
                    continue;
                }
                else
                {
                    if (nums[i] + nums[j]==target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        break;
                    }
                }
            }

        }
        return ans;
        
    }
}