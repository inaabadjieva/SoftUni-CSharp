import java.util.*;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class BookLibrary {
    private String name;
    private ArrayList<Book> books;

     public static void main(String[] args) {
         Scanner scan = new Scanner(System.in);
         int n = scan.nextInt();
         ArrayList<Book> books = new ArrayList<Book>();
         String[] input = scan.nextLine().split(" ");
         for (int i = 0; i < n; i++) {
             input = scan.nextLine().split(" ");
             Book book = new Book();
             book.Title = input[0];
             book.Author = input[1];
             book.Publisher = input[2];
             book.ReleaseDate = input[3];
             book.ISBN = input[4];
             book.Price = Double.parseDouble(input[5]);
             books.add(book);
         }
         BookLibrary library = new BookLibrary();
         library.books = books;
         HashMap<String, Double> map = new HashMap<String, Double>();

         for (Book book : books) {
             if (!map.containsKey(book.Author)) {
                 map.put(book.Author, book.Price);
             } else {
                 map.put(book.Author, map.get(book.Author) + book.Price);
             }
         }
         Set<Map.Entry<String, Double>> entries = map.entrySet();

         TreeMap<String, Double> sorted = new TreeMap<>(map);
         Set<Map.Entry<String, Double>> mappings = sorted.entrySet();

         Comparator<Map.Entry<String, Double>> valueComparator = new Comparator<Map.Entry<String,Double>>() {
             @Override public int compare(Map.Entry<String, Double> e1, Map.Entry<String, Double> e2) {
                 Double v1 = e1.getValue();
                 Double v2 = e2.getValue();
                 return v2.compareTo(v1);
             }
         };

         List<Map.Entry<String, Double>> listOfEntries = new ArrayList<Map.Entry<String, Double>>(mappings);
         Collections.sort(listOfEntries, valueComparator); LinkedHashMap<String, Double> sortedByValue = new LinkedHashMap<String, Double>(listOfEntries.size());
         for(Map.Entry<String, Double> entry : listOfEntries){
             sortedByValue.put(entry.getKey(), entry.getValue());
         }

         Set<Map.Entry<String, Double>> entrySetSortedByValue = sortedByValue.entrySet();
         for(Map.Entry<String, Double> mapping : entrySetSortedByValue){
             System.out.println(String.format("%s -> %.2f", mapping.getKey(), mapping.getValue()));
         }
     }
}

class Book {
    public String Title;
    public String Author;
    public String Publisher;
    public String ReleaseDate;
    public String ISBN;
    public Double Price;
}

