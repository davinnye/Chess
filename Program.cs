using System;
using Boards;
using Pieces;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);
                board.placePiece(new Rook(board, Colors.Black), new MatchPosition(0, 0));
                board.placePiece(new Rook(board, Colors.Black), new MatchPosition(7, 0));
                board.placePiece(new King(board, Colors.White), new MatchPosition(3, 5));


                Screen.printBoard(board);
                Console.ReadLine();
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}