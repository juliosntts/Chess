using System;
using board;

namespace chess
{
    internal class ChessMatch
    {
        public Board Brd { get; private set; }
        private int GameTurn;
        private Color CurrentPlayer;
        public bool MatchEnded { get; private set; }

        public ChessMatch()
        {
            Brd = new Board(8, 8);
            GameTurn = 1;
            CurrentPlayer = Color.White;
            AddPieces();
            MatchEnded = false;
        }

        public void MakeMovement(Position origin, Position destiny)
        {
            ChessPiece p = Brd.RemovePiece(origin);
            p.IncreaseAmountOfMovements();
            ChessPiece pieceCaptured = Brd.RemovePiece(destiny);
            Brd.AddPiece(p, destiny);
        }

        private void AddPieces()
        {
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('a', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('b', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('c', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('d', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('e', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('f', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('g', 2).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.White), new PositionChess('h', 2).ToPosition());
            Brd.AddPiece(new Tower(Brd, Color.White), new PositionChess('a', 1).ToPosition());
            Brd.AddPiece(new Tower(Brd, Color.White), new PositionChess('h', 1).ToPosition());
            Brd.AddPiece(new Horse(Brd, Color.White), new PositionChess('b', 1).ToPosition());
            Brd.AddPiece(new Horse(Brd, Color.White), new PositionChess('g', 1).ToPosition());
            Brd.AddPiece(new Bishop(Brd, Color.White), new PositionChess('c', 1).ToPosition());
            Brd.AddPiece(new Bishop(Brd, Color.White), new PositionChess('f', 1).ToPosition());
            Brd.AddPiece(new Queen(Brd, Color.White), new PositionChess('d', 1).ToPosition());
            Brd.AddPiece(new King(Brd, Color.White), new PositionChess('e', 1).ToPosition());


            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('a', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('b', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('c', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('d', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('e', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('f', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('g', 7).ToPosition());
            Brd.AddPiece(new Pawn(Brd, Color.Black), new PositionChess('h', 7).ToPosition());
            Brd.AddPiece(new Tower(Brd, Color.Black), new PositionChess('a', 8).ToPosition());
            Brd.AddPiece(new Tower(Brd, Color.Black), new PositionChess('h', 8).ToPosition());
            Brd.AddPiece(new Horse(Brd, Color.Black), new PositionChess('b', 8).ToPosition());
            Brd.AddPiece(new Horse(Brd, Color.Black), new PositionChess('g', 8).ToPosition());
            Brd.AddPiece(new Bishop(Brd, Color.Black), new PositionChess('c', 8).ToPosition());
            Brd.AddPiece(new Bishop(Brd, Color.Black), new PositionChess('f', 8).ToPosition());
            Brd.AddPiece(new Queen(Brd, Color.Black), new PositionChess('d', 8).ToPosition());
            Brd.AddPiece(new King(Brd, Color.Black), new PositionChess('e', 8).ToPosition());
        }
    }
}
