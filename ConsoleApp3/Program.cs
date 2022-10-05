using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number of steps");
        int steps = Convert.ToInt32(Console.ReadLine());
        int o = 0;

        for (int y = 0; y < steps * 2; y++)
        {
            for (int x = 0; x < o; x++)
                Console.Write(" ");
            var stars = y % 2 == 0 ? 3 : 1;
            for (int x = 0; x < stars; x++)
            {
                Console.Write("*");
            }
            if (y % 2 == 0)
            {
                o += 2;
            }
            Console.Write("\n");
        }

        Console.WriteLine("Enter number");
        string number = Console.ReadLine();
        var maxValue = number.Max();
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == maxValue)
            {
                PrintNumbers(number[i]);
            }
            else
            {
                PrintStars(number[i]);
            }
        }
    }
    public static void PrintStars(char a)
    {
        switch (a)
        {
            case '0':
                Console.Write(@"
  ***
 *   *
*     *
*     *
*     *
 *   *
  ***");
                break;
            case '1':
                Console.Write(@"
 *
**
 *
 *
 *
 *
***");
                break;
            case '2':
                Console.Write(@"
 ***
*   *
*  *
  *
 *
*
*****");
                break;
            case '3':
                Console.Write(@"
 ***
*   *
   *
  *
   *
*   *
 ***");
                break;
            case '4':
                Console.Write(@"
   * 
  **
 * *
*  *
*****
   *
   *");
                break;
            case '5':
                Console.Write(@"
*****
*
****
    *
    * 
    *
***"); 
                break;
            case '6':
                Console.Write(@"
 ***
*   *
*
****
*   *
*   *
 ***");
                break;
            case '7':
                Console.Write(@"
*****
    *
   *
  *
 *
*
*");
                break;
            case '8':
                Console.Write(@"
 ***
*   *
*   *
 ***
*   *
*   *
 ***");
                break;
            case '9':
                Console.Write(@"
 ****
*   *
*   *
 ****
    *
    *
    *");
                break;
        }

    }

    public static void PrintNumbers(char a)
    {
        switch (a)
        {
            case '0':
                Console.Write(@"
  000
 0   0
0     0
0     0
0     0
 0   0
  000");
                break;
            case '1':
                Console.Write(@"
 1
11
 1
 1
 1
 1
111");
                break;
            case '2':
                Console.Write(@"
 222
2   2
2  2
  2
 2
2
22222");
                break;
            case '3':
                Console.Write(@"
 333
3   3
   3
  3
   3
3   3
 333");
                break;
            case '4':
                Console.Write(@"
   4 
  44
 4 4
4  4
44444
   4
   4");
                break;
            case '5':
                Console.Write(@"
55555
5
5555
    5
    5
    5
555");
                break;
            case '6':
                Console.Write(@"
 666
6   6
6
6666
6   6
6   6
 666");
                break;
            case '7':
                Console.Write(@"
77777
    7
   7
  7
 7
7
7");
                break;
            case '8':
                Console.Write(@"
 888
8   8
8   8
 888
8   8
8   8
 888");
                break;
            case '9':
                Console.Write(@"
 9999
9   9
9   9
 9999
    9
    9
    9");
                break;
        }
    }
}
