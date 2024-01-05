using System;
using board;

namespace Chess
{
    internal class Screen
    {
        public static void PrintBoard(Board brd)
        {

            for (int i = 0; i < brd.Lines; i++)
            {
                for (int j = 0; j < brd.Columns; j++)
                {
                    if (brd.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(brd.Piece(i, j) + " ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
