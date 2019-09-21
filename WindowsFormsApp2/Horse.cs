using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Horse:Piece
    {
        public Horse(int x, int y, String color) : base(x, y, "Horse", color) { }
        public override bool move(int tx, int ty)
        {
            if ((Math.Abs(x - tx) == 1 && Math.Abs(y - ty) == 2)
                || (Math.Abs(x - tx)==2 && Math.Abs(y - ty) == 1))
            {
                x = tx;
                y = ty;
                return true;
            }
            return false;
        }


    }
}
