import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String url = scan.nextLine();

        String protocol = "";
        String server = "";
        String resource = "";

        int index = url.indexOf("://");
        if (index >= 0) {
            for (int i = 0; i < index; i++) {
                protocol += url.charAt(i);
            }
            url = url.substring(index + 3, url.length());
        }
        index = url.indexOf("/");
        if (index >= 0) {
            for (int i = 0; i < index; i++) {
                server += url.charAt(i);
            }
            for (int i = index + 1; i < url.length(); i++) {
                resource += url.charAt(i);
            }
        }
        else {
            for (int i = 0; i < url.length(); i++) {
                server += url.charAt(i);
            }
        }
        System.out.printf("[protocol] = \"%s\"\n", protocol);
        System.out.printf("[server] = \"%s\"\n", server);
        System.out.printf("[resource] = \"%s\"\n", resource);
    }
}
