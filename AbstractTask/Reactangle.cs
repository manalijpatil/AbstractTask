using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    public class Reactangle:Shape
    {
        private int length, width;
        private double area;
        public Reactangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public override void CalculateArea()
        {
            area = length * width;
        }
        public override string ToString()
        {
            return $"Area of Rectangle is :-{area}";
        }
    }
}
