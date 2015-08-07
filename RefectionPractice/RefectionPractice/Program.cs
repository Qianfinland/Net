
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
namespace RefectionPractice
{
    class Program
    {
        private static int m = 10, n = 30;
        static void Main(string[] args)
        {

            //DynamicTest();
            //Test();
        }

        static void DynamicTest()
        {
            List<dynamic> list = new List<dynamic>();
            dynamic
                t1 = new ExpandoObject(),
                t2 = new ExpandoObject();

            t1.Address = "address1";
            t1.ID = 132;

            t2.Address = "address2";
            t2.ID = 133;
            t2.Name = "someName";
            t2.DateTime = DateTime.Now;

            list.AddRange(new[] { t1, t2 });

            // later in your code
            list.Select((obj, index) =>
                new { index, obj }).ToList().ForEach(item =>
                {
                    Console.WriteLine("Object #{0}", item.index);
                    ((IDictionary<string, object>)item.obj).ToList()
                        .ForEach(i =>
                        {
                            Console.WriteLine("Property: {0} Value: {1}",
                                i.Key, i.Value);
                        });
                    Console.WriteLine();
                });

            // or maybe generate JSON
            var s = JsonSerializer.Create();
            var sb = new StringBuilder();
            var w = new StringWriter(sb);
            var items = list.Select(item =>
            {
                sb.Clear();
                s.Serialize(w, item);
                return sb.ToString();
            });

            items.ToList().ForEach(json =>
            {
                Console.WriteLine(json);
            });

            Console.ReadLine();
        }
        static void Test()
        {
            Console.WriteLine("m+n=" + (m + n));
            Console.WriteLine("Enter the name of the variable you want to  change(m or n):");
            string varName = Console.ReadLine();
            Type t = typeof(Program);
            FieldInfo fieldinfo = t.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
            if (fieldinfo != null)
            {
                Console.WriteLine("The current value of " + fieldinfo.Name + " is " + fieldinfo.GetValue(null) + ". You may enter a new value now:");
                string newValue = Console.ReadLine();
                int newInt;
                if (int.TryParse(newValue, out newInt))
                {
                    fieldinfo.SetValue(null, newInt);
                    Console.WriteLine("m + n = " + (m + n));
                }
                Console.ReadKey();
            }
        }
    }
}
