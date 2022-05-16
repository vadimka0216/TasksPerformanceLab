using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2
{
    public class Program
    {
        public static int Run(double[] cycle, double X, double Y)
        {
            int result = 0;
            double radiusSqTest = Math.Pow((cycle[0] - X), 2) + Math.Pow((cycle[1] - Y), 2);
            double radius = Math.Pow(cycle[2],2);
            if (radiusSqTest< radius)
            {
                result = 1;
            }
            else if (radiusSqTest > radius)
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        static double[] ParseCycle(string data)
        {
            double[] result = null;
            Regex pattern = new Regex("(\\S+)\\s+(\\S+)\\s+(\\S+)");
            if (pattern.IsMatch(data))
            {
                result = new double[3];
                Match match = pattern.Match(data);
                for (int i = 0; i < 3; i++)
                {
                    var val = match.Groups[i + 1].Value;
                    if (!double.TryParse(val, out result[i]))
                    {
                        result = null;
                        break;
                    }
                }
            }
            
            return result;
        }
        static double[][] ParsePoints(string data)
        {
            double[][] result = null;
            Regex pattern = new Regex("(\\S+)\\s+(\\S+)");
            if (pattern.IsMatch(data))
            {
                var matches=pattern.Matches(data);
                result = new double[matches.Count][];
                int i = 0;
                foreach (Match m in matches)
                {
                    result[i] = new double[2];

                    string val1 = m.Groups[1].Value;
                    string val2 = m.Groups[2].Value;

                    bool flag1 = double.TryParse(val1,out result[i][0]);
                    bool flag2 = double.TryParse(val2, out result[i][1]);
                    if (!flag1||!flag2)
                    {
                        result = null;
                        break;
                    }
                    i++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                string path1 = args[0];
                string path2 = args[1];
                if (File.Exists(path1) && File.Exists(path2))
                {
                    string dataCycle = File.ReadAllText(path1);
                    string dataPoints = File.ReadAllText(path2);
                    var cycle = ParseCycle(dataCycle);
                    var points = ParsePoints(dataPoints);
                    if (cycle != null && points != null)
                    {
                        for (int i = 0; i < points.Length; i++)
                        {
                            int result = Run(cycle, points[i][0], points[i][1]);
                            Console.WriteLine(result.ToString());
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
