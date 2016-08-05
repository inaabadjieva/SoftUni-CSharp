import java.util.*;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String str1 = scan.nextLine().replace(" ", "");
        char[] chars1 = str1.toCharArray();
        String str2 = scan.nextLine().replace(" ", "");
        char[] chars2 = str2.toCharArray();
        //char[] chars1 = scan.nextLine().toCharArray();
        //char[] chars2 = scan.nextLine().toCharArray();

        boolean areEqual = false;

        for (int i = 0; i < Math.min(chars1.length, chars2.length); i++)
            if(chars1[i] == chars2[i])
                continue;
            else {
                if (chars1[i] < chars2[i]) {
                    System.out.println(chars1);
                    System.out.println(chars2);
                } else {
                    System.out.println(chars2);
                    System.out.println(chars1);
                }
                areEqual = true;
                break;
            }
            if(!areEqual) {
                if (chars1.length < chars2.length) {
                    System.out.println(chars1);
                    System.out.println(chars2);
                } else {
                    System.out.println(chars2);
                    System.out.println(chars1);
                }
            }
    }
}
