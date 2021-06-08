using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oops
{
    class Square:Shape

    {
       private int m_side;
    }
    public Square(int side, string id)
              :base (id)
    {
        m_side = side;
    }
    public override double Area
    {
        m_side = side;

    }
    public override double area
    {
        get
        {
            return m_side * m_side;
        }
    }

}


