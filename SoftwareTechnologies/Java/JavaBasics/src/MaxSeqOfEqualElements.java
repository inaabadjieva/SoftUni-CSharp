import java.util.*;

public class MaxSeqOfEqualElements {
    public static void main(String[] args) {
        int[] nums = Arrays.stream(
                new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();
        int bestNum = 0;
        int length = 1;
        int bestLength = 1;

        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                length++;
            }
            else {
                length = 1;
            }
            if (bestLength < length) {
                bestLength = length;
                bestNum = nums[i];
            }
        }
        for (int i = 0; i < bestLength; i++) {
            System.out.printf(bestNum + " ");
        }
    }
}
