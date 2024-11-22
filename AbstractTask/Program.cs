using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reactangle r1 = new Reactangle(5, 12);
            r1.CalculateArea();
            Console.WriteLine(r1);
        }
    }
}
