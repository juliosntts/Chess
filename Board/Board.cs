namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private ChessPiece[,] ChessPieces;
        
        public Board() { }
        public Board(int lines, int columns) { 
            this.Lines = lines;
            this.Columns = columns;
            ChessPieces = new ChessPiece[lines, columns];
        }

        public ChessPiece Piece(int line, int column)
        {
            return ChessPieces[line, column];
        }

        public void AddPiece(ChessPiece p, Position pos) {
            ChessPieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
    }
}
