using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUZ
{
    static class Program1
    {
        public static void main()
        {
            int[] arr = new int[3]
                .Select(x => new Random().Next(100)).ToArray().Print();

            int[] arr1 = arr.OrderBy(x=>x).ToArray().Print();
            int[] arr2 = arr.OrderByDescending(x=>x).ToArray().Print();

            if (arr.SequenceEqual(arr1))
                "orderBy".Print();

            else if (arr.SequenceEqual(arr2))
                "orderbydescending".Print();

            else
                "dayn".Print();
        }
    }
}
