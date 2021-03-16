using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Figure
    {
        public int x;
        public int y;


        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //змістити фігуру на dx, dy
        public void Move(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
    }
}
