using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_실습_001_제네릭
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics<Int32> genericsInt = new Generics<int>(10);
            Generics<Double> genericsDouble = new Generics<double>(10);

            genericsInt.Add(1, 2, 3, 4);
            genericsDouble.Add(1.1, 5.2, 7.9, 16.3);

            genericsInt.Print();
            genericsDouble.Print();
        }
    }

    public class Generics<T>
    {
        private T[] values;
        private int index;

        public Generics(int length)
        {
            values = new T[length];
            index = 0;
        }

        public void Add(params T[] args)
        {
            foreach (var item in args)
            {
                values[index++] = item;
            }
        }

        public void Print()
        {
            foreach (var item in values)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine();
        }
    }
}
