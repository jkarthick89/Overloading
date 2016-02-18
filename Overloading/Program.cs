using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = GetValue(2);
        }

        static int GetValue(string i)
        {
            return Convert.ToInt32(i);
        }

        static string GetValue(int i)
        {
            return i.ToString();
        }
    }
}
