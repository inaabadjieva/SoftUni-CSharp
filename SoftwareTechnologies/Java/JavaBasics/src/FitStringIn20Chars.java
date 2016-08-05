import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String str = scan.nextLine();
        String result = "";
        if(str.length()>=20){
            result = str.substring(0,20);
        }
        else{
            while(str.length()<20){
                str += "*";
            }
            result += str;
        }
        System.out.print(result);
    }
}
