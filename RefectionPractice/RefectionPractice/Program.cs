
using System;
using System.Reflection;
namespace RefectionPractice
{
    class Program
    {
        private static int m = 10, n = 30;
        static void Main(string[] args)
        {
            Console.WriteLine("m+n=" + (m + n));
            Console.WriteLine("Enter the name of the variable you want to  change:");
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
                    Console.WriteLine("m + n = " + (m+ n ));
                }
                Console.ReadKey();
            }
        }
    }
}
