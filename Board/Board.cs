using System;

namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private ChessPiece[,] ChessPieces;

        public Board() { }
        public Board(int lines, int columns)
        {
            this.Lines = lines;
            this.Columns = columns;
            ChessPieces = new ChessPiece[lines, columns];
        }

        public ChessPiece Piece(int line, int column)
        {
            return ChessPieces[line, column];
        }

        public ChessPiece Piece(Position pos)
        {
            return ChessPieces[pos.Line, pos.Column];
        }

        public bool ExistPiece(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        public bool ValidPosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new ExceptionBoard("Invalid position!");
            }
        }

        public void AddPiece(ChessPiece p, Position pos)
        {
            if (ExistPiece(pos))
            {
                throw new ExceptionBoard("There is already a piece in that position!");
            }
            ChessPieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
    }
}
