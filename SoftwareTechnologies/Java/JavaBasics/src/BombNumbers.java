import java.util.*;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] nums = Arrays.stream(
                scan.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int bombNum = scan.nextInt();
        int left = scan.nextInt();
        int right = left;

        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == bombNum) {
                int start = i - left;
                int end = i + right;
                if (end > nums.length - 1) {
                    right = nums.length - i - 1;
                }
                if (start < 0) {
                    start = 0;
                    for (int j = start; j <= i + right; j++) {
                        nums[j] = 0;
                    }
                }
                else {
                    for (int j = start; j <= i + right; j++) {
                        nums[j] = 0;
                    }
                }
            }
        }
        long sum = 0;
        for (int i = 0; i < nums.length; i++) {
            sum = sum + nums[i];
        }
        System.out.println(sum);
    }
}
