/*1.	С помощью рефлексии получить список методов класса Console и вывести на экран.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Console);
            MethodInfo[] myArrayMethodInfo = type.GetMethods(BindingFlags.Public| BindingFlags.Static|BindingFlags.NonPublic);
            for (int i = 0; i < myArrayMethodInfo.Length; i++)
            {
                MethodInfo myMethodInfo = (MethodInfo)myArrayMethodInfo[i];
                Console.WriteLine("\nThe name of the method is {0}.", myMethodInfo.Name);
              
            }
            Console.ReadLine();

        }
    }
}
