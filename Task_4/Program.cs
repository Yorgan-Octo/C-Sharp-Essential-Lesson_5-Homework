using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Article[] artic = new Article[]
                {
                    new Article("Топиока","Магазик", 3456),
                    new Article("Топиока","Помидорка", 3456),
                    new Article("Топиока","LonsShop", 3456),
                    new Article("Топиока","Магазик", 3456),
                    new Article("Клубника","Помидорка", 3456),
                    new Article("Клубника","Помидорка", 3456),
                    new Article("То что недбзя нахывать","Хлебушек", 3456),
                 };

                Store store = new Store(artic);

                Console.WriteLine(new String('=', 80));
                Console.WriteLine("1 - вивести всі товари; 2 - пошук по номеру; 3 - пошук по назві;");
                Console.WriteLine(new String('=', 80));
                Console.Write("Вмберіть опцію: ");
                string namMenu = Console.ReadLine();
                Console.Clear();

                switch (namMenu)
                {
                    case "1":
                        {
                            store.ShowAll();
                            break;
                        }
                    case "2":
                        {
                            int index;
                            while (true)
                            {

                                try
                                {
                                    Console.Write("Вмберіть номер для пошуку: ");
                                    index = int.Parse(Console.ReadLine());
                                    break;

                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    ErroeShow("Помилка спробуйте ще раз!");
                                }

                            }

                            if (store[index] != null)
                                store[index].ShowInfoProduct();
                            else
                            {
                                ErroeShow("За таким номером нема нічого");
                            }

                            break;
                        }
                    case "3":
                        {
                            Console.Write("Вмберіть назву для пошуку: ");
                            string indexin = Console.ReadLine();

                            int[] indexproduct = store[indexin];
                            if (indexproduct != null)
                            {
                                foreach (int i in indexproduct)
                                {
                                    artic[i].ShowInfoProduct();
                                }
                            }
                            else
                            {
                                ErroeShow("Нама такого");
                            }

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                Console.ReadKey();
                Console.Clear();
            }

        }

        static public void ErroeShow(string errorText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
            Console.ResetColor();
        }

    }
}
