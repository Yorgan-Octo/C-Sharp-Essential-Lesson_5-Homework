using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary dictionary = new Dictionary();

            while (true)
            {
                Console.WriteLine(new String('-', 90));
                Console.WriteLine("Вас вытай найбільший Англійсько - Українсько - Французький перекладач у світі версія 2.0");
                Console.WriteLine(new String('-', 90));
                Console.Write("Введіть слово для переклада: ");
                string words = Console.ReadLine();

                Console.WriteLine(new String('-', 50));
                Console.WriteLine(dictionary[words]);
                Console.WriteLine(new String('-', 50));

                Console.WriteLine("\nНатисныть на будь яку кнопку щоб продовжити!");
                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}
