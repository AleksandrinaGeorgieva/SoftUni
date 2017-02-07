using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        public double left { get; set; }
        public double top { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double right { get; set; }
        public double bottom { get; set; }

        public static Rectangle Create(double l, double t, double w, double h)
        {
            var rect = new Rectangle();
            rect.left = l;
            rect.top = t;
            rect.width = w;
            rect.height = h;
            rect.bottom = t + h;
            rect.right = l + w;

            return rect;
        }

        public bool IsInside(Rectangle rect)
        {
            bool inside = false;// rect == vun6niq
            if(left >= rect.left && top >= rect.top
                && left + width <= rect.left + rect.width
                && right <= rect.right && bottom <= rect.bottom)
            {
                inside = true;
            }
            return inside;
        }
    }
}
