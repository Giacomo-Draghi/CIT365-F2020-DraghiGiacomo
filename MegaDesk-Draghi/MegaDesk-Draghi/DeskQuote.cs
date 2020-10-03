using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Draghi
{
    class DeskQuote : Desk
    {
        public string name { set; get;}
        public int shipping { set; get; }
        public string date { set; get; }

        public DeskQuote (float w, float d, int dr, string m, int sh, string da)
        {
            width = w;
            depth = d;
            numOfDrawer = dr;
            matirial = m;
            shipping = sh;
            date = da;
        }

        public float Area(float w, float d)
        {
            w = width;
            d = depth;
            float area = w * d;
            return area;
        }

        public float AreaPrice (float w, float d)
        {
            w = width;
            d = depth;
            float area = w * d;
            float price;
            if (area < 1000)
            {
                return price = 200;
            }
            else
            {
                return price = area - 800;
            }
        }

        public float DrawerPrice (int n)
        {
            n = numOfDrawer;
            float price = 50 * n;
            return price;
        }

        public float MaterialPrice (string m)
        {
            m = matirial;
            float price;
            if (m == "Oak")
            {
                return price = 200;
            } else if (m == "Laminate")
            {
                return price = 100;
            } else if (m == "Pine")
            {
                return price = 50;
            } else if (m == "Rosewood")
            {
                return price = 300;
            } else
            {
                return price = 125;
            }
        }

        public int ShippingPrice (int s)
        {
            s = shipping;
            int price;

            if (s == 3){
                if (Area(width, depth) < 1000 )
                {
                    return price = 60;
                } else if (Area(width, depth) >= 1000 &&
                    Area(width, depth) <= 2000)
                {
                    return price = 70;
                } else
                {
                    return price = 80;
                }
            } else if (s == 5)
            {
                if (Area(width, depth) < 1000)
                {
                    return price = 40;
                }
                else if (Area(width, depth) >= 1000 &&
                  Area(width, depth) <= 2000)
                {
                    return price = 50;
                }
                else
                {
                    return price = 60;
                }
            } else if (s == 7) {
                if (Area(width, depth) < 1000)
                {
                    return price = 30;
                }
                else if (Area(width, depth) >= 1000 &&
                  Area(width, depth) <= 2000)
                {
                    return price = 35;
                }
                else
                {
                    return price = 40;
                }
            } else
            {
                return price = 0;
            }
        }

        public string Name (string n)
        {
            name = n;
            return n;
        }

        public string Date (string d)
        {
            d = date;
            return d;
        }
    }
}
