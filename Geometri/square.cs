using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
   public class Square
    {
        private double Side { get; set; }

       /* public void SetSide(double laengde, int v)
        {
            Side = laengde;
        }
       */
        internal void SetSide(int laengde)
        {
            Side = laengde;
        }

        public Square (double laengde)
        {
            Side = laengde;
        }

        public double Omkreds()
        {
            return 4 * Side;
        }

    }
}
