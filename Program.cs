using System;
using System.Collections.Generic;

namespace ReorderList
{
    public class Program
    {
        private static int _n;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n(ctrl+c to exit)Please Enter N [1-9 ]:");
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out _n);
                Get();
            }//while
        }
        static void Get()
        {
            //take/skip/range

            #region assignment
            var list = new List<char> { 'a', 'a', 'a', 'a', 'b', 'b', 'c', 'd', 'e', };
            var newList = new List<char>();
            var count = list.Count;
            if (_n >= count)
            {
                Console.WriteLine("the N need less List Count.");
                return;
            }
            #endregion

            #region algorithm
            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < list.Count; j++)
                {
                    var currentChar = list[j];
                    
                    if ((newList.Count > _n ? newList.GetRange(newList.Count - _n, _n) : newList).Contains(
                        currentChar)) continue;

                    newList.Add(currentChar);//add to newList
                    list.RemoveAt(j);//remove from list
                    break;//skip
                }//for
            }//for
            #endregion

            //output
            Console.WriteLine($"\nN is {_n},the reorder list is:[" + (string.Join(" ", newList)) + "]");
        }
    }
}