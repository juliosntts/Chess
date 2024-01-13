using board;

namespace chess
{
    internal class Horse : ChessPiece
    {
        public Horse(Board brd, Color color) : base(color, brd)
        {
        }

        public override string ToString()
        {
            return "H";
        }
    }
}