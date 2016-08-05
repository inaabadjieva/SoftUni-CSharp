import java.util.*;

public class Circle{
    public double CenterX;
    public double CenterY;
    public double Radius;

    public double getCenterX() {
        return CenterX;
    }

    public void setCenterX(double centerX) {
        this.CenterX = centerX;
    }

    public double getCenterY() {
        return CenterY;
    }

    public void setCenterY(double centerY) {
        CenterY = centerY;
    }

    public double getRadius() {
        return Radius;
    }

    public void setRadius(double radius) {
        Radius = radius;
    }

    public static double CalcCenterDistance(Circle c1, Circle c2)
    {
        double a = c1.CenterX - c2.CenterX;
        double b = c1.CenterY - c2.CenterY;
        double distance = Math.sqrt(a * a + b * b);
        return distance;
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double[] coords1 = Arrays.stream(
                scan.nextLine().split(" "))
                .mapToDouble(Double::parseDouble).toArray();
        Circle c1 = new Circle();
        c1.CenterX = coords1[0];
        c1.CenterY = coords1[1];
        c1.Radius = coords1[2];
        double[] coords2 = Arrays.stream(
                scan.nextLine().split(" "))
                .mapToDouble(Double::parseDouble).toArray();
        Circle c2 = new Circle();
        c2.CenterX = coords2[0];
        c2.CenterY = coords2[1];
        c2.Radius = coords2[2];

        double distance = Circle.CalcCenterDistance(c1, c2);
        if (distance <= c1.Radius + c2.Radius) {
            System.out.printf("Yes");
        }
        else {
            System.out.printf("No");
        }
    }
}
