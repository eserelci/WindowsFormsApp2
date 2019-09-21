using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract class Piece
    {
        public int x, y;
        public String name;
        public String color;
        public Piece(int x,int y,String name,String color)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public abstract bool move(int tx, int ty);
        public virtual bool attack(int tx,int ty)
        {
            return move(tx, ty);
        }

    }
}
