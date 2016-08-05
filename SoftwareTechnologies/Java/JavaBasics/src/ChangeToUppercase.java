import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        StringBuilder text = new StringBuilder(scan.nextLine());

        int start = text.indexOf("<upcase>");
        int end = text.indexOf("</upcase>");
        String toUpper = "";
        while (start != -1) {
            for (int j = start + 8; j < end; j++) {
                toUpper += text.charAt(j);
            }
            toUpper = toUpper.toUpperCase();
            text = text.delete(start, start + toUpper.length() + 17);
            text = text.insert(start, toUpper);
            toUpper = "";
            start = text.indexOf("<upcase>");
            end = text.indexOf("</upcase>");
        }
        String result = text.toString();
        System.out.println(result);
    }
}

