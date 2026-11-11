public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        // 1. Declaring the result product for the first element of array.
        result[0] = 1;

        // 2. Calculating the left product for each element of the array.
        for(int i = 1; i < n; i++)
        {
            result[i] = result[i-1] * nums[i-1];
        }

        int snowball = 1;
        // 3. Calculating the final product of array except itself.
        for(int i = n - 1; i >= 0; i--)
        {
            result[i] = result[i] * snowball;
            snowball = snowball * nums[i];
        }

        return result;
    }
}
