import java.util.*;
import java.util.stream.Collectors;

public class Student {

    private String Name;
    private ArrayList<Double> Grades;
    private double AverageGrade;

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public ArrayList<Double> getGrades() {
        return Grades;
    }

    public void setGrades(ArrayList<Double> grades) {
        Grades = grades;
    }

    public double getAverageGrade() {
        return AverageGrade;
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();

        List<Student> students = new ArrayList<Student>();

        for (int i = 0; i <= n; i++) {
            ArrayList<Double> grades = new ArrayList<Double>();
            Student student = new Student();

            String[] input = scan.nextLine().split(" ");

            double sum = 0;
            for (int j = 1; j < input.length; j++) {
                grades.add(Double.parseDouble(input[j]));
                sum += Double.parseDouble(input[j]);
            }
            student.Name = input[0];
            student.Grades = grades;
            student.AverageGrade = sum / grades.size();

            students.add(student);
        }

        List<Student> bestStudents = students.stream().filter(p -> p.getAverageGrade() >= 5.00).collect(Collectors.toList());
        Comparator<Student> byName = (e1, e2) -> e1.getName().compareTo(e2.getName());
        Comparator<Student> byGrade = (e1, e2) -> Double.compare(e2.getAverageGrade(), e1.getAverageGrade());
        bestStudents.stream().sorted(byName.thenComparing(byGrade))
                .forEach(e -> System.out.printf("%s -> %.2f\n", e.getName(), e.getAverageGrade()));
    }
}

