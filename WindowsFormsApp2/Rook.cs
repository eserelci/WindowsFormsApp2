using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Rook : Piece
    {
        public Rook(int x,int y, String color) :base(x, y, "Rook", color) { }
        public override bool move(int tx, int ty)
        {
            if (x == tx || y==ty)
            {
                x = tx;
                y = ty;
                return true;
            }
            return false;
        }
    }
}
