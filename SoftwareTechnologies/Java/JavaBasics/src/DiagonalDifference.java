import java.util.Scanner;
import java.util.Arrays;

public class DiagonalDifference {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int[][] matrix = new int [n][n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = scan.nextInt();
            }
        }
        int leftDiagonal = 0;
        int rightDiagonal = 0;
        //left diagonal
        int row = 0;
        int col = 0;
        for (int i = 0; i < n; i++)
        {
            leftDiagonal += matrix[row][col];
            row++;
            col++;
        }
        //right diagonal
        row = 0;
        col = n -1;
        for (int i = 0; i < n; i++)
        {
            rightDiagonal += matrix[row][col];
            row++;
            col--;
        }
            System.out.println(Math.abs(rightDiagonal-leftDiagonal));
    }
}
