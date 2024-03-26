using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUZ
{
    static class Program2
    {
        public static void main()
        {
            int[] arr = new int[10]
                .Select(x => new Random().Next(-10, 10)).ToArray().Print()
                .Select(x => x < 0 ? -x:x).ToArray().Print()
                .Where(x=>x!=0).ToArray().Print();

        }
    }
}
