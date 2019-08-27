using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "q,w,e,r,t";
            string[] arr=new string[5]{"a","b","c","d","e"};
       
            string[] tem = s.Split(',');
            for (int i = 0; i < tem.Length; i++)
            {
                arr[i] = tem[i];
            }
            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
