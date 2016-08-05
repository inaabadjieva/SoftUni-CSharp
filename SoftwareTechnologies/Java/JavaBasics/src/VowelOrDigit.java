import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char x = scan.next().charAt(0);
        if(Character.isDigit(x))
            System.out.print("digit");
        else if(x=='a' || x=='A' || x=='e' || x=='E' ||
                x=='i' || x=='I' || x=='o' || x=='O' ||
                x=='u' || x=='U')
            System.out.print("vowel");
        else
            System.out.print("other");
    }

}

