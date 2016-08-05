import java.util.*;

public class HexToDecimal {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String hex = scan.nextLine();
        int decimal = Integer.parseInt(hex, 16);
        System.out.print(decimal);
    }
}
