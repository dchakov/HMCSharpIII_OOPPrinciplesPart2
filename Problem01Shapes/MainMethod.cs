using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Shapes
{
    class MainMethod
    {
        static void Main()
        {
            Shape[] array =
            {
              new Square(2.3),
              new Square(2),
              new Rectangle(1.5,2),
              new Triangle(3.3,4.2)
            };
            foreach (Shape item in array)
            {
                Console.WriteLine("Shape = {0} surface = {1}",item.GetType().Name,item.CalculateSurface());
            }
        }
        
    }
}
