
package Medvedkov;
import java.util.Scanner;
import Teryokhin;
import Generate;
import Max;

public class Main {
    public static void main(String[] args) {
        Generate g = Generate();
        int[] arr = g.gen();
        Max m = Max(arr);
        int m = m.max();
        System.out.println(m);
        Teryokhin out = Teryokhin(arr);
        out.print();

    }
}