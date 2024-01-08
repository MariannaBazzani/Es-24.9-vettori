using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_24._9_vettori
{
    internal class Vector
    {
        public double Xvector { get; set; }
        public double Yvector { get; set; }
        
        public Vector() { }
        public Vector(double x, double y)
        {
            this.Xvector = x;
            this.Yvector = y;
        }

        public Vector Somma(Vector V)
        {
            Vector Vresult = new Vector();
            Vresult.Xvector = V.Xvector + Xvector;
            Vresult.Yvector = V.Yvector + Yvector;
            
            return Vresult;
        }
    }


}
