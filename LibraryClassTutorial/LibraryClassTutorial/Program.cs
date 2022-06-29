using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MathLib()
        }
    }

    public class MathLib
    {
        public int Add(int x, int y)
        {
            return x + y+1;
        }
    }
}
