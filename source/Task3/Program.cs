using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        struct stFile1
        {
            public struct stValues
            {
                public stValues(int _id, string _value)
                {
                    id = _id;
                    value = _value;
                }
                public int id;
                public string value;
            }
            public List<stValues> values;
        }
        struct stFile2
        {
            public struct stTests
            {
                public stTests(int _id, string _title, string _value, List<stFile2.stTests> _values)
                {
                    id = _id;
                    title = _title;
                    value = _value;
                    values = _values;
                }
                public int id;
                public string title;
                public string value;
                public List<stFile2.stTests> values;//string
                public void setValue(string _value)
                {
                    value = _value;
                }
            }
            public List<stTests> tests;
        }
        static void TryReplace(ref stFile2.stTests tests, int id, string value)
        {
            if (tests.values!=null)
            {
                for (int i=0; i<tests.values.Count; i++)
                {
                    var buf = tests.values[i];
                    TryReplace(ref buf, id, value);
                    tests.values[i] = buf;
                }
            }
            if (tests.id==id)
            {
                tests.setValue(value);
            }
        }

        static string fileReport = "report.json";
        static void Main(string[] args)
        {
            if (args.Length==2)
            {
                string fileTests = args[0];
                string fileValues = args[1];
                if (File.Exists(fileTests)&&File.Exists(fileValues))
                {
                    string tests = File.ReadAllText(fileTests);
                    string vals = File.ReadAllText(fileValues);
                    var arrValues=JsonConvert.DeserializeObject<stFile1>(vals);
                    var arrTests = JsonConvert.DeserializeObject<stFile2>(tests);
                    
                    if (arrValues.values!=null&&arrTests.tests!=null)
                    {
                        var values = arrValues.values;
                        var testsjs = arrTests.tests;
                        foreach (var val in values)
                        {
                            for (int i = 0; i < testsjs.Count; i++)
                            {
                                var buf = testsjs[i];
                                TryReplace(ref buf, val.id, val.value);
                                testsjs[i] = buf;
                            }
                        }

                        arrTests.tests = testsjs;
                        var settings = new JsonSerializerSettings();
                        settings.NullValueHandling = NullValueHandling.Ignore;
                        string result = JsonConvert.SerializeObject(arrTests, settings);
                        File.WriteAllText(fileReport, result);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
