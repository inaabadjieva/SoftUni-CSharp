import java.util.Arrays;
import java.util.Scanner;

public class CensorYourEmail {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String email = scan.nextLine();

        String[] text = scan.nextLine().split(" ");

        String username = email.split("@")[0];
        String domain = email.split("@")[1];
        String stars = "";
        for (int i = 0; i < username.length(); i++) {
            stars+="*";
        }
        String mail = stars + "@" + domain;

        for (int i = 0; i < text.length; i++)
        {
            if (text[i].equals(email))
                text[i] = mail;
        }
        System.out.print(String.join(" ", text));
    }
}
