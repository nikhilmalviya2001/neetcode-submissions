public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] result = new int[n];

        // 1. Declaring the Left and right product for the first & last element of array.
        left[0] = 1;
        right[n-1] = 1;

        // 2. Calculating the left product for each element of the array.
        for(int i = 1; i < n; i++)
        {
            left[i] = left[i-1] * nums[i-1];
        }

        // 3. Calculating the right product for each element of the array.
        for(int i = n - 2; i >= 0; i--)
        {
            right[i] = right[i+1] * nums[i+1];
        }

        // 4. Calculing the Product of Array except the self.
        for(int i = 0; i < n; i++)
        {
            result[i] = left[i] * right[i];
        }

        return result;
    }
}
