import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Formatter;


public class base_class {

    base_class(int n) {
        arr = new int[n];
        this.n = n;
        for (int i = 0; i < n; i++) {
            arr[i] = (int) (Math.random() * 10);
        }
    }

    public Formatter process() {
        int even_sum = 0, odd_sum = 0;
        for (int i = 0; i < arr.length; i++) {
            if (i % 2 == 0){
                even_sum += arr[i];
            }
            else{
                odd_sum += arr[i];
            }
        };
        Formatter f = new Formatter();
        f.format("Сумма чётных чисел %d, сумма нечтных чисел %d, из них большая - %d", even_sum, odd_sum, Math.max(odd_sum, even_sum));
//        String res = f;
        return f;
    }

    public String print() {
        String s = Arrays.toString(arr);
        return s;
    }

    protected int[] arr;
    protected int n;
}
