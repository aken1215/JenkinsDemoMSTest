using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMsBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Test";

            string b = "";
            if (a == "Test")
            {
                b = "Test";
            }
            else if(a=="Test1")
            {
                b = "Test1";
            }

            SetStatus(b);
        }

        private static void SetStatus(string b)
        {

        }
    }
}
