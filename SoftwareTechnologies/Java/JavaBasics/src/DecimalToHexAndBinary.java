import java.util.Scanner;

public class DecimalToHexAndBinary {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int decimal = scan.nextInt();
        String hex = Integer.toHexString(decimal);
        String binary = Integer.toString(decimal,2);
        System.out.print(hex.toUpperCase() + "\n");
        System.out.print(binary);
    }
}
