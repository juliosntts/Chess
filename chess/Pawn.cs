using board;

namespace chess
{
    internal class Pawn : ChessPiece
    {
        public Pawn(Board brd, Color color) : base(color, brd)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}