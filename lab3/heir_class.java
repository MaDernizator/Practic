import java.util.Arrays;
import java.util.Formatter;

public class heir_class extends base_class {

    heir_class(int n) {
        super(n);
        arr = new int[n][];
        for (int i = 0; i < n; i++) {
            int nn = (int) (Math.random() * 10);
            int[] arr_v = new int[nn];
            for (int j = 0; j < nn; j++) {
                arr_v[j] = (int) (Math.random() * 100) - 50;
            }
            arr[i] = arr_v;
        }
    }
    private int[] find(){
        double m = -1.0 / 0.0;
        int res_i = -1,res_c = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                if (arr[i][j] > m) {
                    m = arr[i][j];
                    res_i = i;
                }
                if (arr[i][j] < 0 & (arr[i][j] * (-1)) % 2 == 1){
                    res_c++;
                }
            }
        }
        int[] ans = new int[2];
        ans[0] = res_i;
        ans[1] = res_c;
        return ans;
    }

    private int[] find_i(int count){
        int[] res = new int[count];
        int ii = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                if (arr[i][j] < 0 & arr[i][j] % 2 == 1) {
                    res[ii] = i;
                    ii++;
                }
            }
        }
        return res;
    }
    private boolean find_el(int el, int n, int[] ar){
        for (int i = 0; i < n; i++) {
            if (ar[i] == el) {return true;}
        }
        return false;
    }
    public void dup(){
        int[] a = find();
        int i_el = a[0], count = a[1];
        int[] is = find_i(count);
        int[][] arr_v = new int[n + count][];
        int s = 0;
        for (int i = 0; i < n + count; i++) {
            arr_v[i - s] = arr[i - s];
            if (find_el(i, count, is)){
                i++;
                arr[i] = arr[i_el];
                s++;
            }
        }

        this.arr = arr_v;
        n = n + count;

    }
    public String[] print_f() {
        String[] res = new String[n];
        for (int i = 0; i < n; i++) {
            res[i] = Arrays.toString(arr[i]);
        }
        return res;
    }

//    public Formatter process() {
//        ;
//    }

    private int[][] arr;

}
