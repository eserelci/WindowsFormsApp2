using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Board
    {
        private Piece[,] board;
        public Board()
        {
            board = new Piece[8, 8];
            board[2, 7] = new Elephant(2, 7, "white");
            board[5, 7] = new Elephant(5, 7, "white");
            board[0, 7] = new Rook(0, 7, "white");
            board[7, 7] = new Rook(7, 7, "white");
            board[1, 7] = new Horse(1, 7, "white");
            board[6, 7] = new Horse(6, 7, "white");
            board[4, 7] = new King(4, 7, "white");
            board[3, 7] = new Queen(3, 7, "white");
            for(int i=0;i<8;i++)
                board[i, 6] = new Pion(i, 6, "white");

        }
        public bool move(int sx,int sy,int tx,int ty)
        {
            if (board[sx, sy] == null)
                return false;

            if (board[tx, ty] != null)
            {
                if (board[tx, ty].color.Equals(board[sx, sy].color))
                {
                        return false;
                }

                if (board[sx, sy].attack(tx, ty))
                {
                    board[tx, ty] = board[sx, sy];
                    board[sx, sy] = null;
                    return true;
                }
                return false;
            }


            if (board[sx, sy].move(tx, ty))
            {
                board[tx, ty] = board[sx, sy];
                board[sx, sy] = null;
                return true;
            }
            return false;
        }
    }
}
