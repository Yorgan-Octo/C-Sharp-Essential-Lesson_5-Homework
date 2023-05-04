using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Dictionary
    {
        private string[] englishWords = new string[5];
        private string[] polishWords = new string[5];
        private string[] ukrainianWords = new string[5];


        public Dictionary()
        {
            ukrainianWords[0] = "книга"; englishWords[0] = "book"; polishWords[0] = "boek";
            ukrainianWords[1] = "ручка"; englishWords[1] = "pen"; polishWords[1] = "pinne";
            ukrainianWords[2] = "сонце"; englishWords[2] = "sun"; polishWords[2] = "sinne";
            ukrainianWords[3] = "яблуко"; englishWords[3] = "apple"; polishWords[3] = "appel";
            ukrainianWords[4] = "стіл"; englishWords[4] = "table"; polishWords[4] = "tafel";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < englishWords.Length; i++)
                    if (englishWords[i].ToLower() == index.ToLower())
                        return $"{englishWords[i]} - {ukrainianWords[i]} - {polishWords[i]}";

                for (int i = 0; i < polishWords.Length; i++)
                    if (polishWords[i].ToLower() == index.ToLower())
                        return $"{polishWords[i]} - {ukrainianWords[i]} - {englishWords[i]}";

                for (int i = 0; i < ukrainianWords.Length; i++)
                    if (ukrainianWords[i].ToLower() == index.ToLower())
                        return $"{ukrainianWords[i]} - {polishWords[i]} - {englishWords[i]}";


                return $"{index} - немає перекладу для цього слова.";
            }
        }
    }
}
