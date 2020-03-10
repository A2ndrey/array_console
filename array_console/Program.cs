using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // test();
            
            // string[] s = Console.ReadLine().Split();

            // array:

            // multiplyofthree(true);
            // multiplyofthree(false);
            //morethanprevious();
            //swapelement();
            //differentsign();
            swipetoright();


            Console.ReadKey();

        }


        private static void swipetoright()
        {
           
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = new string[n];
            a = s.Split(' ');

            Console.Write(a[n-1] + " ");
            for (int i = 0; i < n-1; i++)
                Console.Write(a[i] + " ");
 
        }

        private static void differentsign()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int previous = 0;
            bool res = false;

            for (int i=0; i<n; i++)
            {
                if (i == 0)
                {
                    previous = Convert.ToInt32(ss[i]);
                    continue;
                }

                if ((Convert.ToInt32(ss[i]) * previous) > 0)
                {
                    res = true;
                    break;
                }

                previous = Convert.ToInt32(ss[i]);

            }

            Console.WriteLine(res ? "YES" : "NO");
        }

        private static void swapelement()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = new string[n];
            string trash = "";

            a = s.Split(' ');

            for (int i = 0; i < n; i = i+2)
            {
                if ((i + 1) <= (n - 1))
                {
                    trash = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = trash;
                }

            }

            foreach (string el in a)
                Console.Write(el +" ");

            //            Sample Input 1:
            //5
            //9 4 5 2 3
            //Sample Output 1:
            //4 9 2 5 3
            //Sample Input 2:
            //4
            //1 2 3 4
            //Sample Output 2:
            //2 1 4 3
        }
        private static void morethanprevious()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] array = new string[n];
            array = s.Split(' ');
            int previous = Convert.ToInt32(array[0]);

            var count = 0;

            foreach (string a in array)
            {

                if (Convert.ToInt32(a) > previous)
                    count++;
                previous = Convert.ToInt32(a);
            }

            Console.WriteLine(count);


        }


        private static void multiplyofthree(bool needindex = false)
        {

            const int digit = 3;

            int n = Convert.ToInt32(Console.ReadLine());
            int checknumber;
            string s = Console.ReadLine();
            string[] array = new string[n];
            array = s.Split(' ');
            for (int i = 0; i < n; i++)
            {

                checknumber = needindex ? i : Convert.ToInt32(array[i]);
                if (checknumber % digit == 0)
                    Console.Write(array[i] + " ");
            }

        }

        public static void test()
        {
            Random rnd = new Random();

            int[] test_array = new int[10];
            for (int i = 0; i < 10; i++)
                test_array[i] = rnd.Next(0, 10);

            foreach (int a in test_array)
                Console.WriteLine(a);

            int length = test_array.Length;
            Console.WriteLine($"Длина массива: {length}");
        }
    }
}
