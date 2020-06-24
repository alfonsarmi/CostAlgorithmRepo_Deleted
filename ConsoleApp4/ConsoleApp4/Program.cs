using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a new comment
            var a = 1;
            if (a == 1)
            {
                switch (a)
                {
                    case 1:
                        var aa = 1;
                        Test();
                        break;
                    case 2:
                        var b = 2;
                        break;

                    default:
                        //do nothing
                        break;
                }
            }			

		}

        private static void Test()
        {
            var a = 1 + 2;
        }
    }
}
