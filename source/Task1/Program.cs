using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        static void ReadParams(string data, out int a, out int b)
        {
            a = b = -1;
            var args = data.Split('\n');
            if (args.Length==2)
            {
                var sa=args[0].Replace("\r","");
                var sb = args[1].Replace("\r", "");
                if (int.TryParse(sa, out a))
                {
                    int.TryParse(sb, out b);
                }
            }
        }
        public static string Run(int n, int m)//taks1
        {
            string result = "";
            //string debug = "";
            //int[] array = new int[n];
            //for (int i=1; i<=n; i++)
            //{
            //    array[i] = i;
            //}
            int curr = 1; int index = 0; int buffer = 1;
            while (true)
            {
                //debug += curr.ToString();

                curr = ((curr) % (n + 1)+1);//next
                if (curr == n+1) curr = 1;
                index = ++index % m;//next

                if (index == m - 1)
                {
                    result += buffer.ToString();
                    if (curr == 1||m==1)
                    {
                        break;
                    }
                    else
                    {
                        buffer = curr;
                        curr--;
                    }
                }
            }
            return result;
        }
        static void Main0(string[] args)//read in file
        {
            if (args.Length==1)
            {
                string path = args[0];
                if (File.Exists(path))
                {
                    string data=File.ReadAllText(path);
                    int a, b;
                    ReadParams(data, out a, out b);
                    if (a>0&&b>0)
                    {
                        Console.WriteLine(Run(a,b));
                    }
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)//args - numbers
        {
            if (args.Length == 2)
            {
                string sa = args[0];
                string sb = args[1];
                int a=-1, b=-1;
                if (int.TryParse(sa, out a))
                {
                    if (int.TryParse(sb, out b))
                    {
                        if (a > 0 && b > 0)
                        {
                            Console.WriteLine(Run(a, b));
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
