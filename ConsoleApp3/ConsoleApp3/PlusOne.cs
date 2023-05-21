using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static  class PlusOne
    {
        public static int[] Plus(int[] digits)
        {
            //string[] numch = new string[x.Length];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    numch[i] = Convert.ToString(x[i]);
            //}
            //if ( int.Parse(String.Join("", numch)) > int.MaxValue)
            //{
            //    int xy = int.Parse(String.Join("", numch)) / int.MaxValue;
            //    int num1 = int.Parse(String.Join("", numch)) % int.MaxValue;
            //    num1++;
            //    string numst = ((xy*int.MaxValue)+num1).ToString();
            //    int[] answer = new int[numst.Length];
            //    List<string> result = new List<string>();
            //    for (int i = 0; i < numst.Length; i++)
            //    {
            //        result.Add(numst[i].ToString());
            //    }
            //    for (int i = 0; i < result.Count; i++)
            //    {
            //        answer[i] = int.Parse(result[i]);
            //    }
            //    return answer;
            //}
            //else
            //{
            //    long num = long.Parse(String.Join("", numch));
            //    num++;
            //    string numst = num.ToString();
            //    int[] answer = new int[numst.Length];
            //    List<string> result = new List<string>();
            //    for (int i = 0; i < numst.Length; i++)
            //    {
            //        result.Add(numst[i].ToString());
            //    }
            //    for (int i = 0; i < result.Count; i++)
            //    {
            //        answer[i] = int.Parse(result[i]);
            //    }
            //    return answer;
            //}

       
                string[] numch = new string[digits.Length];
                for (int i = 0; i < digits.Length; i++)
                {
                    numch[i] = Convert.ToString(digits[i]);
                }
                decimal num = decimal.Parse(String.Join("", numch));


                num++;
                string numst = num.ToString();
                int[] answer = new int[numst.Length];
                List<string> result = new List<string>();
                for (int i = 0; i < numst.Length; i++)
                {
                    result.Add(numst[i].ToString());
                }
                for (int i = 0; i < result.Count; i++)
                {
                    answer[i] = int.Parse(result[i]);
                }
                return answer;
            }
        }
    }

