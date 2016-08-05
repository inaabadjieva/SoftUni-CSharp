import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {

    public static void main(String[] args) {
        int[] nums = Arrays.stream(
                new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        boolean equalSums = false;
        for (int i = 0; i < nums.length; i++) {
            int sumLeft = 0;
            int sumRight = 0;
            for (int j = 0; j < i; j++) {
                sumLeft += nums[j];
            }
            for (int j = i + 1; j < nums.length; j++) {
                sumRight += nums[j];
            }
            if (sumLeft == sumRight) {
                System.out.println(i);
                equalSums = true;
            }
        }
        if (equalSums == false) {
            System.out.printf("no");
        }
    }
}
