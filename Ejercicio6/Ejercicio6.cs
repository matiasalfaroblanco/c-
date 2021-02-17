using System;
using Modulo1.Ejercicio6;

namespace Modulo1.Ejercicio6
{
    public class User<T>
    {
        private T[] data = new T[5];
        private int max = 0;

        public void Add(T x)
        {
            data[max] = x;
            max++;
        }

        public T Remove()
        {
            max--;
            return data[max];
        }
    }

    class Program
    {
        public static void Main()
        {
            User<int> data1 = new User<int>();
            data1.Add(1);
            data1.Add(2);
            Console.WriteLine("Usuarios Int: ");
            Console.WriteLine(data1.Remove());

            User<string> data2 = new User<string>();
            data2.Add("agus");
            data2.Add("ruben");
            Console.WriteLine(data2.Remove());
        }
    }
}