import java.util.Arrays;
import java.util.Scanner;


public class MostFrequentNumber {
    public static void main(String[] args) {
        char[] alphabet = new char[26];
        char first = 'a';
        for (int i = 0; i < alphabet.length; i++) {
            alphabet[i] = first;
            first++;
        }
        Scanner scan = new Scanner(System.in);
        char[] word = scan.nextLine().toCharArray();

        for (int i = 0; i < word.length; i++)
        {
            char letter = word[i];
            int index = new String(alphabet).indexOf(letter);
            System.out.printf("%c -> %d\n", letter, index);
        }

    }
}
