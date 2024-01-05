using board;

namespace chess
{
    internal class Tower : ChessPiece
    {
        public Tower(Board brd, Color color) : base(color, brd)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
