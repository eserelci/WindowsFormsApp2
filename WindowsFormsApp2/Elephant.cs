using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Elephant :Piece
    {
        public Elephant(int x,int y, String color) :base(x,y,"Elephant",color){}
        public override bool move(int tx,int ty)
        {
            if (Math.Abs(x - tx) == Math.Abs(y - ty))
            {
                x = tx;
                y = ty;
                return true;
            }
            return false;
        }
    }
}
