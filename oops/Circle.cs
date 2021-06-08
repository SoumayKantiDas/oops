using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Circle: Shape
    {
        private int m_radius;
        public Circle(int radius, string id)
            :base(id)
        {
            m_radius = radius;
        }
        public override double Area
        {
            get
            { 
                //Given the radious retun the area of a circle:
                return m_radius * m_radius * Math.PI;
            }
        }

    }
}
