using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// compile with: cse /target:library abstractshape.cs
/// </summary>
namespace oops
{
    public abstract class Shape
    {
        private string m_id;
        public Shape(string s)
        {
            // calling the set accessor of the Id property.
            Id = s;
        }
        public string Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        //Area is a read-only property - only get accessor is needed
        public abstract double Area
        {
            get;
            set;
        }
        public override string ToString()
        {
            return Id + "Area =" + string.Format("{0:F2}", Area);
        }
    }
}
