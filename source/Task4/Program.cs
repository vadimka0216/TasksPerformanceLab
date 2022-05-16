using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    public class Program
    {
        static int[] ReadParams(string data)
        {
            var args = data.Split('\n');
            int[] result = new int[args.Length];
            int i = 0;
            foreach (var arg in args)
            {
                var real = arg.Replace("\r", "");
                if (!int.TryParse(real, out result[i]))
                {
                    result = null;
                    break;
                }
                i++;
            }
            return result;
        }
        public static int RunV0(int[] nums)
        {
            int result = 0;
            double ave = nums.Average();
            double deviation = 0;
            foreach (var num in nums)
            {
                deviation+=Math.Abs(ave-num);
            }
            result = (int)Math.Round(deviation);
            return result;
        }
        public static int Run(int[] nums)
        {
            int result = 0;
            double ave = nums.Average();
            int mainInt = nums[0];
            double deviation = Math.Abs(ave-mainInt);
            foreach (var num in nums)
            {
                double buf = Math.Abs(ave - num);
                if (deviation>buf)
                {
                    mainInt = num;
                    deviation = buf;
                }
            }

            foreach (var num in nums)
            {
                double count = Math.Abs(num - mainInt);
                result += (int)count;//condition count - real
            }

            return result;
        }
        static void Main(string[] args)
        {
            if (args.Length==1)
            {
                string nameFile = args[0];
                if (File.Exists(nameFile))
                {
                    string data = File.ReadAllText(nameFile);
                    var nums = ReadParams(data);
                    if (nums != null && nums.Length > 0)
                    {
                        int res = Run(nums);
                        Console.WriteLine(res.ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
