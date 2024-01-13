using board;

namespace chess
{
    internal class Queen : ChessPiece
    {
        public Queen(Board brd, Color color) : base(color, brd)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}