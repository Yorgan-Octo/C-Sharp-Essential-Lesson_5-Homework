using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Store
    {

        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        public Article this[int intdex]
        {
            get
            {
                if (intdex >= 0 && intdex < articles.Length)
                    return articles[intdex];
                else
                    return null;


            }
        }

        //це як вариант якщо потрибно повернути декілька значень а не тільки одне
        //також можно булоб вікористати окрему функцію
        public int[] this[string intdex]
        {
            get
            {
                List<int> search = new List<int>();

                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name.ToLower() == intdex.ToLower())
                    {
                        search.Add(i);
                    }
                }

                if (search.Count != 0)
                {
                    return search.ToArray();
                }

                return null;

            }
        }

        public void ShowAll()
        {
            foreach (Article article in articles)
            {
                article.ShowInfoProduct();
            }
        }

    }
}
