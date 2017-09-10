/*2.	Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства.
 *  С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. Вывести полученные значения на экран*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflection reflection = new Reflection();
            reflection.Age = 13;
            reflection.Name = "Assel";
            reflection.Id = 951;
            Type type = typeof(Reflection);
            FieldInfo[] myArrayOfFields = type.GetFields(BindingFlags.NonPublic| BindingFlags.Public|BindingFlags.Instance);
            for (int i = 0; i < myArrayOfFields.Length; i++)
            {
                FieldInfo name = (FieldInfo)myArrayOfFields[i];
                Console.WriteLine("{0}", name.Name);
            }
            Console.ReadLine();
        }
    }
}

