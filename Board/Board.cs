namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private ChessPiece[,] ChessPieces;
        
        public Board() { }
        public Board(int line, int columns) { 
            this.Lines = line;
            this.Columns = columns;
            ChessPieces = new ChessPiece[Lines, Columns];
        }
    }
}
