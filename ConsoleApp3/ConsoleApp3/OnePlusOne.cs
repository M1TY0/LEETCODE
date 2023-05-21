using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static public class OnePlusOne
    {
        static public int Plus(int num)
        {
            string numS = num.ToString();
            int numLenght = numS.Length;
            char[] chars = new char[numLenght];
            string answer;
            for (int i = 0; i < numLenght; i++)
            {
                chars[i] = (char)numS[i];
            }
            bool isonly9 = false;
            for (int i = 0; i < numLenght; i++)
            {
                if(chars[i]=='9')
                {
                    isonly9 = true;
                }
                else
                {
                    isonly9 = false;
                    break;
                }
            }
            if(isonly9)
            {
                
                answer = string.Join("",chars);
                return int.Parse(answer);
            }
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '6')
                {
                    chars[i] ='9';
                    answer = string.Join("", chars);
                    return int.Parse(answer);
                }
            }
            return 0;
        }
    }
}
