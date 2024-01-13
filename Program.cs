using System;
using board;
using chess;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch match = new ChessMatch();

                Screen.PrintBoard(match.Brd);

            }
            catch (ExceptionBoard e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
