using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitDLL
{
    public class Class1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string Reverse(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
