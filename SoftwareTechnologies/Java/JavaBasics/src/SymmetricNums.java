import java.util.Scanner;

public class SymmetricNums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        for (int i = 1; i <= n; i++) {
            if(isSymmetric("" + i))
                System.out.print(i + " ");
        }
    }

    private static boolean isSymmetric(String str) {
        for (int i = 0; i < str.length(); i++) {
            if(str.charAt(i) != str.charAt(str.length() -i -1))
                return false;
        }
        return true;
    }
}
