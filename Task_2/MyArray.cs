using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class MyArray
    {

        private int[] array = new int[10];


        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }

        }
        public void ShowArray()
        {
            Console.WriteLine(new String('-', 50));
            Console.Write("Весь масив: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Максемальне значення масива: {array.Max()}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Мінімальне значення масива: {array.Min()}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Сума всіх єлементів: {array.Sum()}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Cереднє арифметичне всіх елементів: {Math.Round(array.Average(), 2)}");
            Console.WriteLine(new String('-', 50));

            Console.Write("Усі непарні значення: ");
            foreach (var item in Array.FindAll(array, n => n % 2 != 0))
            {
                //oddValues += item + " ";
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new String('-', 50));
        }

    }
}
