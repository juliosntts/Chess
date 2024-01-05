using System;
using board;
using chess;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board brd = new Board(8,8);

            brd.AddPiece(new Tower(brd, Color.Black), new Position(0,0));
            brd.AddPiece(new Tower(brd, Color.Black), new Position(1,3));
            brd.AddPiece(new King(brd, Color.Black), new Position(2,4));

            Screen.PrintBoard(brd);

            Console.ReadLine();
        }
    }
}
