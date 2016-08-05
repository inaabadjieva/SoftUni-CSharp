import java.util.Arrays;
import java.util.Scanner;

public class MaxIncreasingSequaence {
    public static void main(String[] args) {
        int[] nums = Arrays.stream(
                new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int maxCount = 0;
        int startIndex = 0;
        int count = 0;
        int index = 0;

        for (int i = 1; i < nums.length; i++)
        {
            if (nums[i - 1] < nums[i])
            {
                count++;
                index = i - count;
                if (count > maxCount)
                {
                    maxCount = count;
                    startIndex = index;
                }
            }
            else
            {
                count = 0;
            }
        }
        for (int i = startIndex; i <= startIndex + maxCount; i++)
        {
            System.out.printf(nums[i] + " ");
        }
        System.out.printf("\n");
    }
}
