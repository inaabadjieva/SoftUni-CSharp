import java.util.Scanner;

public class Matrix3x3 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int rows = scan.nextInt();
        int cols = scan.nextInt();
        long [][] matrix = new long[rows][cols];

        //reading the matrix
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i][j] = scan.nextLong();
            }
        }

        long maxSum = Long.MIN_VALUE;
        long[][] result = new long[3][3];

        for (int row = 0; row < rows - 2; row++) {
            for (int col = 0; col < cols - 2; col++) {
                long sum = 0;
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        sum += matrix[row + i][col + j];
                    }
                }
                if (sum > maxSum) {
                    maxSum = sum;
                    for (int i = 0; i < 3; i++) {
                        for (int j = 0; j < 3; j++) {
                            result[i][j] = matrix[row + i][col + j];
                        }
                    }
                }
            }
        }
        System.out.println(maxSum);
        for (int row = 0; row < 3; row++) {
            for (int col = 0; col < 3; col++) {
                System.out.printf(result[row][col] + " ");
            }
            System.out.printf("\n");
        }
    }
}