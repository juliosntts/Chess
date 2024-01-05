namespace board
{
    internal class ChessPiece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int AmountOfMovements { get; protected set; }
        public Board Brd { get; protected set; }

        public ChessPiece() { }
        public ChessPiece (Color color, Board brd)
        {
            this.Position = null;
            this.Color = color;
            this.Brd = brd;
            this.AmountOfMovements = 0;
        }

    }
}
