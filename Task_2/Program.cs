using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            MyArray myArray = new MyArray();

            for (int i = 0; i < 10; i++)
            {
                myArray[i] = rnd.Next(0,30);
            }

            myArray.ShowArray();

            Console.ReadKey();

        }
    }
}
