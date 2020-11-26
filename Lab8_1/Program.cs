using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();

            baseClass[0] = "Hello";
            baseClass[1] = "World";

            Console.WriteLine(baseClass[0] + " " + baseClass[1]);
            Console.ReadLine();
        }
    }
}
