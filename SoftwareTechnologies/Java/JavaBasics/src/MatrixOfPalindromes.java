import java.util.Arrays;
import java.util.Scanner;

public class MatrixOfPalindromes {
    public static void main(String[] args) {
        int[] dimentions = Arrays.stream(
                new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int rows = dimentions[0];
        int cols = dimentions[1];
        String [][] matrix = new String[rows][cols];
        char letter = 'a';
                for (int row = 0; row < rows; row++) {
                    char middleLetter = letter;
                    for (int col = 0; col < cols; col++) {
                        System.out.printf("%c%c%c ", letter, middleLetter, letter);
                        middleLetter++;
                    }
                    letter++;
                    System.out.printf("\n");
                }
    }
}
