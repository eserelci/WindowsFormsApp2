using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Pion : Piece
    {
        private bool firstMove;
        public Pion(int x, int y, String color) : base(x, y, "Pion", color) { firstMove = true; }
        public override bool move(int tx, int ty)
        {
            if (x==tx &&( y - ty== 1  || (y - ty == 2 && firstMove == true) )) { 
                x = tx;
                y = ty;
                firstMove = false;
                return true;
            }
            return false;
        }

        public override bool attack(int tx, int ty)
        {
            if ((x == tx - 1 || x == tx + 1) && (y - ty == 1 ))
            {
                x = tx;
                y = ty;
                firstMove = false;
                return true;
            }
            return false;
        }

    }
}
