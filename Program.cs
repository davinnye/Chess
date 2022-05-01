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
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.ended)
                {
                    Console.Clear();
                    Screen.printBoard(chessMatch.Board);

                    Console.WriteLine();
                    Console.Write("Piece origin ");
                    MatchPosition origin = Screen.readMatchPosition().toChessPosition();

                    bool[,] possiblePositions = chessMatch.Board.pc(origin).allowedMovements();
                    Console.Clear();
                    Screen.printBoard(chessMatch.Board, possiblePositions);

                    Console.WriteLine();
                    Console.Write("Piece destiny ");
                    MatchPosition destiny = Screen.readMatchPosition().toChessPosition();
                    chessMatch.performMovement(origin, destiny);
                }

                
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}