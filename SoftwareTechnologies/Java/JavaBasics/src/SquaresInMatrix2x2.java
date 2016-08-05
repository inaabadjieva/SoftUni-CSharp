import java.util.Arrays;
import java.util.Scanner;

public class SquaresInMatrix2x2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int rows = scan.nextInt();
        int cols = scan.nextInt();
        String [][] matrix = new String[rows][cols];

        //reading the matrix
        for (int i = 0; i < rows; i++) {
            /*String str = scan.nextLine().replace(" ", "");
            char[] rowValues = str.toCharArray();*/
            for (int j = 0; j < cols; j++) {
                matrix[i][j] = scan.next();
            }
        }

        int count = 0;

        for (int row = 0; row < rows - 1; row++) {
            for (int col = 0; col < cols - 1; col++) {
                String letter = matrix[row][col];
                String letterRight = matrix[row+1][col];
                String letterDown = matrix[row][col+1];
                String letterDownRight = matrix[row+1][col+1];

                if (letter.equals(letterRight) && letter.equals(letterDown) && letter.equals(letterDownRight))
                    count++;
            }
        }
        System.out.println(count);
    }
}

