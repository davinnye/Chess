using System;
using Boards;
using Pieces;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);
            board.placePiece( new Rook(board, Colors.Black), new Position(0,0));
            board.placePiece( new Rook(board, Colors.Black), new Position(7,0));
            board.placePiece( new King(board, Colors.White), new Position(3,5));


            Screen.printBoard(board);
            Console.ReadLine();
        }
    }
}
