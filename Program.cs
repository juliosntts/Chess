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

                while (!match.MatchEnded)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.Brd);

                    Console.WriteLine();
                    Console.WriteLine("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();
                    Console.WriteLine("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();

                    match.MakeMovement(origin, destiny);
                }

            }
            catch (ExceptionBoard e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
