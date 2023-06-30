// Include namespace system
using System;
using System.Linq;

using System.IO;

using System.Collections;
public class base_class
{
    public base_class(int n)
    {
        this.arr = new int[n];
        this.n = n;
        for (int i = 0; i < n; i++)
        {
            Random rnd = new Random();
            this.arr[i] = (int)(rnd.Next(1,100));
        }
    }
    public string process()
    {
        var even_sum = 0;
        var odd_sum = 0;
        for (int i = 0; i < this.arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                even_sum += this.arr[i];
            }
            else
            {
                odd_sum += this.arr[i];
            }
        }
        return (string)string.Format("Сумма чётных чисел {0}, сумма нечтных чисел {1}, из них большая - {2}", even_sum,odd_sum,Math.Max(odd_sum,even_sum));
    }
    public String print()
    {
        var s = string.Join(", ",this.arr);
        return s;
    }
    protected int[] arr;
    protected int n;
}
public class heir_class : base_class
{
    public heir_class(int n)  : base(n)
    {
        this.arr = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Random rnd = new Random();
            var nn = (int)(rnd.Next(1, 10));
            var arr_v = new int[nn];
            for (int j = 0; j < nn; j++)
            {
                arr_v[j] = (int)(rnd.Next(1, 100)) - 50;
            }
            this.arr[i] = arr_v;
        }
    }
    private int[] find()
    {
        var m = -1000;
        var res_i = -1;
        var res_c = 0;
        for (int i = 0; i < this.n; i++)
        {
            for (int j = 0; j < this.arr[i].Length; j++)
            {
                if (this.arr[i][j] > m)
                {
                    m = this.arr[i][j];
                    res_i = i;
                }
                if (this.arr[i][j] < 0 & (this.arr[i][j] * (-1)) % 2 == 1)
                {
                    res_c++;
                }
            }
        }
        var ans = new int[2];
        ans[0] = res_i;
        ans[1] = res_c;
        return ans;
    }
    private int[] find_i(int count)
    {
        var res = new int[count];
        var ii = 0;
        for (int i = 0; i < this.n; i++)
        {
            for (int j = 0; j < this.arr[i].Length; j++)
            {
                if (this.arr[i][j] < 0 & this.arr[i][j] % 2 == 1)
                {
                    res[ii] = i;
                    ii++;
                }
            }
        }
        return res;
    }
    private bool find_el(int el, int n, int[] ar)
    {
        for (int i = 0; i < n; i++)
        {
            if (ar[i] == el)
            {
                return true;
            }
        }
        return false;
    }
    public void dup()
    {
        var a = this.find();
        var i_el = a[0];
        var count = a[1];
        var is_ = this.find_i(count);
        var arr_v = new int[this.n][];
        //var arr_v = new int[this.n + count][];
        var s = 0;
        for (int i = 0; i <= this.n; i++)
        {
            if (i >= this.n) break;
            arr_v[i - s] = this.arr[i - s];
            if (this.find_el(i, count, is_))
            {
                //i++;
                this.arr[i] = this.arr[i_el];
                //s++;
            }
        }
        this.arr = arr_v;
        this.n = this.n;
        //this.n = this.n + count;
    }
    public String[] print_f()
    {
        var res = new String[this.n];
        for (int i = 0; i < this.n; i++)
        {
            res[i] = string.Join(", ",arr[i].Select(x => x.ToString()));
        }
        return res;
    }
    private int[][] arr;
}
public class TwoArray
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Размер массива: ");
        var n = Convert.ToInt32(Console.ReadLine());
        var class1 = new base_class(n);
        Console.WriteLine("Массив: ");
        Console.WriteLine(class1.print());
        Console.WriteLine(class1.process());
        var class2 = new heir_class(n);
        Console.WriteLine("Двумерный массив: ");
        foreach (var i in class2.print_f())
        {
            Console.WriteLine(i);
        }
        class2.dup();
        Console.WriteLine("Изменённый массив массив: ");
        foreach (var i in class2.print_f())
        {
            Console.WriteLine(i);
        }
    }
}