import java.util.*;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Map<String, String> phonebook = new TreeMap<String, String>();
        String input = scan.nextLine();
        while(!input.equals("END")) {
            String[] params = input.split(" ");
            if (params[0].equals("A")) {
                String phone = params[2];
                if (phonebook.containsKey(params[1])){
                    phonebook.put(params[1], phone);
                }
                else{
                    phonebook.put(params[1], phone);
                }
            }
            else if (params[0].equals("S")) {
                String searched = params[1];

                if (phonebook.containsKey(searched)) {
                    System.out.printf(searched + " -> " + phonebook.get(searched) + "\n");
                }
                else {
                    System.out.printf("Contact " + searched + " does not exist.\n");
                }
            }
            else if (params[0].equals("ListAll")) {
                for(Map.Entry<String,String> entry : phonebook.entrySet()) {
                    System.out.println(entry.getKey() + " -> " + entry.getValue());
                }
            }
            input = scan.nextLine();
        }
    }
}