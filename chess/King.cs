using board;

namespace chess
{
    internal class King : ChessPiece 
    {
        public King(Board brd, Color color) :base(color, brd) { 
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
