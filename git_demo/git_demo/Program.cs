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
            //Console.WriteLine("Enter the a");
            //int a=int.Parse(Console.ReadLine());
            Console.WriteLine(addingtwonumnbers(4,8));
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
    #endregion
}
}
