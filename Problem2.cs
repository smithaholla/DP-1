public class HouseRobber
    {
        // Time Complexity : O(n)
        // Space Complexity : O(n) --can be reduced to O(1) by using 2 variables to keep track of i-1 and i-2 since those are the only values we need
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int n = nums.Length;
            int[] dp = new int[n];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
            }

            return dp[n - 1];
        }
}
