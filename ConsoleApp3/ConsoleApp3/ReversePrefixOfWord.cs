using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp3
{
    static public class ReversePrefixOfWord
    {
        static public string Reverse(string word,char ch)
        {
            List<char> ReversePart = new List<char>();
            string answer = null;
            if (word.Contains(ch)==false)
            {
                return word;
            }
            int lenght = word.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (word[0] != ch)
                {
                    ReversePart.Add(word[0]);
                    word=word.Substring(1);
                }
                else
                {

                    ReversePart.Add(word[0]);
                    word = word.Substring(1);
                    ReversePart.Reverse();
                    answer = string.Join("", (ReversePart))+word;
                    return answer;
                }

            }
            return answer;
        }
    }
}
