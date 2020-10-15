using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ReorderList
{
    public class Program
    {
        static List<char> list = new List<char> { 'a', 'a', 'a', 'a', 'b', 'b', 'c', 'd', 'e', };
        //output: [a, b, c, d, a, b, e], N=3
        //output: [a, b, c, a, b, d, a, e], N=2
        static int N;
        static List<char> newList = new List<char>();

        public static void Main(string[] args)
        {
            Console.Write("enter N=");
            N = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

            Get();

            Console.WriteLine("reorder list is:" + newList.ToArray());
            Console.WriteLine();
        }
        static void Get()
        {
            var i = 0;
            while (true)
            {
                if (list.Count == 0)
                    break;

                //take/skip

                for (int j = 0; j < list.Count; j++)
                {
                    var a = list[j];
                    newList.Add(a);
                    list.RemoveAt(i);
                    break;
                }
                //if (newList.Count == 0 || (i > newList.Count && newList[i + N] != a)
                //|| (i > N && newList[i - N] != a))
                //{

                //}

                i++;
            }


        }
    }
}
