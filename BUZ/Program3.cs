using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BUZ
{
    static class Program3
    {
        public static void main()
        {
            int[] arr = new int[10]
                .Select(x=> new Random().Next(100)).ToArray().Print();
            arr[0..5]
                .Concat(new int[] { 0 }).ToArray()
                .Concat(arr[5..^0]).Print();
            //arr.Concat(new int[] { 0, 0,0 }).ToArray().Print();
        }
    }
}
