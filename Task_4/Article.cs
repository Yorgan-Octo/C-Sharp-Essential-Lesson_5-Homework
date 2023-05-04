using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Article
    {
        private string name;
        private string nameShop;
        private int priсe;

        public string Name
        {
            get { return name; }
        }

        public Article(string name, string nameShop, int priсe)
        {
            this.name = name;
            this.nameShop = nameShop;
            this.priсe = priсe;
        }

        public void ShowInfoProduct()
        {
            Console.WriteLine(new String('=',80));
            Console.WriteLine($" Название: {name} | Магазин: {nameShop} | Цена: {priсe} ");
            Console.WriteLine(new String('=', 80));
        }


    }
}
