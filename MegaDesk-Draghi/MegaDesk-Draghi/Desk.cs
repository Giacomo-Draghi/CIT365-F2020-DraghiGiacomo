using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Draghi
{
    class Desk
    {
        public float width { set; get; }
        public float depth { set; get; }
        public string matirial { set; get; }
        public int numOfDrawer { set; get; }

        public float Width (float w)
        {
            w = width;
            return w;
        }

        public float Depth (float d)
        {
            d = depth;
            return d;
        }

        public string Matirial (string m)
        {
            m = matirial;
            return m;
        }

        public int NumberOfDrwer (int n)
        {
            n = numOfDrawer;
            return n;
        }
    }
}
