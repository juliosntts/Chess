using board;

namespace chess
{
    internal class Bishop : ChessPiece
    {
        public Bishop(Board brd, Color color) : base(color, brd)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}