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

            // multiplyofthree(true);
            // multiplyofthree(false);
            // morethanprevious();
            // swapelement();
            // differentsign();
            // swipetoright();
            // index_of_max();
            // minus_minel();
            // difference_between_max_and_min();
            // swap_firstmin_with_secondmax();
            // polyndrom();
            // samedigit();
            // singleel();
            // sidedigonale();
            // simmetricmatrix();
            // multiplytable();
            // trianglePascale();
            // firstmaxinmatrix();

            Console.ReadKey();

        }


        private static void firstmaxinmatrix()
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s[0]);
            int m = Convert.ToInt32(s[1]);

            int[,] a = new int[n, m];


            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(s[j]);

            }

            var max = 0;
            var line = 0;


            for (int i = n - 1; i > 0; i--)
            {
                int sum = 0;

                for (int j = 0; j < m; j++)
                    sum += a[i, j];

                if (sum > max)
                {
                    max = sum;
                    line = i;
                }

            }

            Console.WriteLine(max);
            Console.WriteLine(line);

        }

        private static void trianglePascale()
        {

            string[] s = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(s[0]);
            int m = Convert.ToInt32(s[1]);

            int[,] a = new int[n, m];

            var res = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if ((i == 0) && (j == 0))
                        res = 1;
                    else
                    {
                        if (((j - 1) < 0) && ((i - 1) >= 0))
                            res = a[i - 1, j];
                        else if (((j - 1) >= 0) && ((i - 1) >= 0))
                            res = a[i, j - 1] + a[i - 1, j];

                        else if (((i - 1) < 0) && ((j - 1) >= 0))
                            res = a[i, j - 1];
                    }

                    a[i, j] = res;
                }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }


        }

        private static void multiplytable()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            //string[] s = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(s[0]);
            //int m = Convert.ToInt32(s[1]);
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    // a[i, j] = i * j;
                    Console.Write((i + 1) * (j + 1) + " ");
                Console.WriteLine();

            }
        }
        private static void simmetricmatrix()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            var result = true;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    array[i, j] = Convert.ToInt32(s[j]);

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] != array[j, i])
                    {
                        result = false;
                        break;
                    }
                    if (result == false)
                        break;
                }
            }

            Console.WriteLine(result ? "YES" : "NO");

        }

        private static void sidedigonale()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j == ((n - 1 - i))) && (i == (n - 1 - j)))
                        array[i, j] = 1;

                    else if ((n - i) > j)
                        array[i, j] = 0;
                    else
                        array[i, j] = 2;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
        }

        private static void singleel()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = new string[n];
            ss = s.Split(' ');

            var isnotsingle = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)

                    if ((ss[i] == ss[j]) && (i != j))
                    {
                        isnotsingle = true;
                        break;
                    }

                if (isnotsingle == true)
                {
                    isnotsingle = false;
                    continue;
                }
                else
                    Console.Write(ss[i] + " ");
            }



        }

        private static void samedigit()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ss = new string[n];

            ss = Console.ReadLine().Split(' ');
            var res = false;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (ss[j] == ss[i])
                    {
                        res = true;
                        break;
                    }
                if (res)
                    break;
            }

            Console.WriteLine(res ? "YES" : "NO");
        }
        private static void polyndrom()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ss = Console.ReadLine().Split(' ');

            var res = true;
            for (int i = 0; i < ss.Length / 2; i++)
                if (ss[i] != ss[ss.Length - 1 - i]) res = false;

            Console.WriteLine(res ? "YES" : "NO");



        }
        private static void swap_firstmin_with_secondmax()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a = Console.ReadLine().Split(' ');

            int first_min = Convert.ToInt32(a[0]);
            int second_max = Convert.ToInt32(a[0]);

            var index_min = 0;
            var index_max = 0;

            for (int i = 1; i < n; i++)
            {
                if (Convert.ToInt32(a[i]) < first_min)
                {
                    index_min = i;
                    first_min = Convert.ToInt32(a[i]);
                }

                if (Convert.ToInt32(a[i]) > second_max)
                {
                    index_max = i;
                    second_max = Convert.ToInt32(a[i]);
                }
            }

            for (int i = index_max + 1; i < n; i++)
                if (Convert.ToInt32(a[i]) == second_max)
                {
                    index_max = i;
                    break;
                }

            a[index_min] = a[index_max];
            a[index_max] = Convert.ToString(first_min);

            foreach (string el in a)
                Console.Write(el + " ");

        }

        private static void difference_between_max_and_min()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = new string[n];
            ss = s.Split(' ');

            int max_digit = Convert.ToInt32(ss[0]);
            int min_digit = Convert.ToInt32(ss[0]);
            int max_index = 0;
            int min_index = 0;

            for (int i = 1; i < n; i++)
            {
                if (Convert.ToInt32(ss[i]) > max_digit)
                {
                    max_digit = Convert.ToInt32(ss[i]);
                    max_index = i;
                }
                if (Convert.ToInt32(ss[i]) < min_digit)
                {
                    min_digit = Convert.ToInt32(ss[i]);
                    min_index = i;
                }
            }

            Console.WriteLine(max_index - min_index);
        }

        private static void minus_minel()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = new string[n];
            ss = s.Split(' ');

            int[] a = new int[n];
            int min = Convert.ToInt32(ss[0]);

            for (int i = 1; i < n; i++)
                if (Convert.ToInt32(ss[i]) < min)
                {
                    min = Convert.ToInt32(ss[i]);
                }

            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(ss[i]) - min;

            foreach (int el in a)
                Console.Write(el + " ");

        }

        private static void index_of_max()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = new string[n];
            ss = s.Split(' ');

            int min = Convert.ToInt32(ss[0]);
            int minindex = 0;

            for (int i = 1; i < n; i++)
                if (Convert.ToInt32(ss[i]) < min)
                {
                    min = Convert.ToInt32(ss[i]);
                    minindex = i;
                }

            Console.WriteLine(minindex);

        }

        private static void swipetoright()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = new string[n];
            a = s.Split(' ');

            Console.Write(a[n - 1] + " ");
            for (int i = 0; i < n - 1; i++)
                Console.Write(a[i] + " ");

        }

        private static void differentsign()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int previous = 0;
            bool res = false;

            for (int i = 0; i < n; i++)
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

            for (int i = 0; i < n; i = i + 2)
            {
                if ((i + 1) <= (n - 1))
                {
                    trash = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = trash;
                }

            }

            foreach (string el in a)
                Console.Write(el + " ");

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
