import java.util.Scanner;
import java.lang.*;
import java.io.*;
 
/* Name of the class has to be "Main" only if the class is public. */
class Converter
{
    public static void main (String[] args) throws java.lang.Exception
    {
        System.out.println("00000000");
        Scanner inp = new Scanner(System.in);
        int number = inp.nextInt();
        int system = inp.nextInt();
		if (number == 0)
	   {
		   System.out.println("0");
		   System.exit(0);
	   }
		String[] alp  = new String[] {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"};
		String r="";
       while(number > 0)
       {
          r = alp[(number % system)] + r;
          number = number / system;
       }
        System.out.println(r);
    }
}