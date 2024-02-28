using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{

    namespace CalculateRadiusCircle
    {
        class Circle
        {
            private double radius;

            
            public Circle(double r)
            {
                radius = r;
            }

            
            public double CalculateArea()
            {
                return Math.PI * Math.Pow(radius, 2);

            }

            public double CalculateCircumference()
            {
                return 2 * Math.PI * radius;
            }

            ~Circle()
            {
                Console.WriteLine("The Circle object has been destroyed.");
            }
        }
    }
}
    