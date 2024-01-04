using System;
using board;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board brd = new Board(8,8);

            Console.WriteLine(brd);
        }
    }
}
