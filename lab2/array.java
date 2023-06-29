public class Main {
    public static void task5() {
        int arr[] = {1, 2, 3, 4, 5, 6, 7};
        for (int i : arr) {
            if ((i % 2) == 0) {
                System.out.println(i);
            }
        }
        for (int i : arr) {
            if ((i % 2) != 0) {
                System.out.println(i);
            }
        }
    }

    public static void task4() {
        int arr[] = {1, 2, 3, 3, 3, 4, 5, 5, 6, 7, 7, 7, 7, 7, 7};
        int len = 1;
        for (int i = 1; i < arr.length; i++) {
            if ((arr[i - 1]) == arr[i]) {
                len++;
            } else {
                System.out.println(len);
                len = 1;
            }
        }
        System.out.println(len);

    }

    public static void main(String[] args) {
        task4();
        task5();
    }
}