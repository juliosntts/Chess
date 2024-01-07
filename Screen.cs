using System;
using board;
using chess;

namespace Chess
{
    internal class Screen
    {
        public static void PrintBoard(Board brd)
        {

            for (int i = 0; i < brd.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.Columns; j++)
                {
                    if (brd.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(brd.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static void PrintPiece(ChessPiece Piece)
        {
            if (Piece.Color == Color.White)
            {
                Console.Write(Piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(Piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}


