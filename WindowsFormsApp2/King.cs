using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class King : Piece
    {
        public King(int x, int y, String color) : base(x, y, "King", color) { }
        public override bool move(int tx, int ty)
        {
            if (Math.Abs(x - tx) <= 1 && Math.Abs(y - ty) <= 1)
            {
                x = tx;
                y = ty;
                return true;
            }
            return false;
        }
    }
}
