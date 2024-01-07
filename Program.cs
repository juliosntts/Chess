using System;
using board;
using chess;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PositionChess pos = new PositionChess('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosition());

            Console.ReadLine();
        }
    }
}
