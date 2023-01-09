using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_demo
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine(addingtwonumnbers(4,8));
            Console.WriteLine(dividetwonumnbers(10,2));
        }

    
    #region Adding the two numbers
        public static int addingtwonumnbers(int a, int b)
        {
            int c = 0;
            c = a + b;
            return c;
        }
    #endregion
    #region divide the two numbers 
        public static int dividetwonumnbers(int a, int b)
        {
            int c = 0;
            c = a / b;
            return c;
        }

    #endregion
}
}
